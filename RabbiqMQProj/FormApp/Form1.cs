using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RabbitMQ.Client;//

namespace FormApp
{
    public partial class Form1 : Form
    {
        private bool _isConnection = false;

        private bool isConnectionOpen { get; set; }

        private IConnection connection;

        private IModel _channel;
        private IModel channel => _channel ?? (_channel = CreateOrGetChannel());
       
        public Form1()
        {
            InitializeComponent();
            txtConnectionString.Text = "amqp://guest:guest@localhost:5672";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlMain.Enabled = false;
            Init();
            ConnectionStateChanged();

            cbDeclareExchangeType.SelectedIndex = 0;
            cbExchangeType.SelectedIndex = 0;
        }

        #region App methods

        private IConnection GetConnection()
        {
            ConnectionFactory factory = new ConnectionFactory()
            {
                Uri = new Uri(txtConnectionString.Text, UriKind.RelativeOrAbsolute)
            };

            return factory.CreateConnection();
        }

        private IModel CreateOrGetChannel()
        {
            return connection.CreateModel();    
        }

        private void WriteDataToExchange(string exchangeName, string routingKey, object data)
        {
            var dataArr = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data));
            channel.BasicPublish(exchangeName, routingKey, null, dataArr);        
        }

        private void ConnectionStateChanged()
        {
            btnConnect.Text = isConnectionOpen ? "Disconnect" : "Connect";

            UpdateConnectionStatus();

            pnlMain.Enabled = isConnectionOpen;
        }

        private void UpdateConnectionStatus()
        {
            string state = $"{ (isConnectionOpen ? "" : "Not ") } Connected";
            lblStateConnectionStatus.Text = $"Connection State: {state}";
            AddLog($"Connection State is {state}");
        }

        private void AddLog(string logStr)
        {
            logStr = $"[{DateTime.Now.ToString("dd:MM:yyyy hh:mm:ss")}] - {logStr}";
            txtLog.AppendText($"{logStr}");
            txtLog.AppendText(Environment.NewLine);

            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }

        private void Init()
        {
            cbDeclareExchangeType.Items.Add("direct");
            cbDeclareExchangeType.Items.Add("fanout");
            cbDeclareExchangeType.Items.Add("headers");
            cbDeclareExchangeType.Items.Add("topic");

            cbExchangeType.Items.Add("direct");
            cbExchangeType.Items.Add("fanout");
            cbExchangeType.Items.Add("headers");
            cbExchangeType.Items.Add("topic");

            cbDeclareExchangeType.SelectedIndex = cbExchangeType.SelectedIndex - 0;
        }

        #endregion

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!isConnectionOpen || connection == null)
            {
                connection = GetConnection();
            }
            else
            {
                connection.Close();
            }

            isConnectionOpen = connection.IsOpen;

            ConnectionStateChanged();
        }

        private void btnDeclareExchange_Click(object sender, EventArgs e)
        {
            channel.ExchangeDeclare(txtDeclareExchangeName.Text, cbDeclareExchangeType.Text);
            AddLog($"Exchange created with Name:{txtDeclareExchangeName.Text}, Type: {cbDeclareExchangeType.Text}");
        }

        private void btnDeclareQueue_Click(object sender, EventArgs e)
        {
            channel.QueueDeclare(txtDeclareQueueName.Text, false, false, false);
            AddLog($"Queue created with Name:{txtDeclareQueueName.Text}");
        }

        private void btnBindQueue_Click(object sender, EventArgs e)
        {
            channel.QueueBind(txtDeclareQueueName.Text, txtDeclareExchangeName.Text, txtDeclareRoutingKey.Text);
            AddLog($"Exchange with Name:{txtDeclareExchangeName.Text} binded to Queue with Name:{txtDeclareQueueName.Text} with Routing Key: {txtDeclareRoutingKey.Text}");
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            var message = txtMessage.Text;

            for (int i = 1; i <=numeriRepeatCount.Value; i++)
            {
                if (chbxUseCounter.Checked)
                {
                    message = $"[{i + 1}]-{txtMessage.Text}";
                }

                WriteDataToExchange(txtExchangeName.Text, txtRoutingKey.Text, message);
            }

            AddLog($"numeriRepeatCount.Value Message Published to  Exchange with Name:{txtDeclareExchangeName.Text} binded to Queue with Name:{txtDeclareQueueName.Text} with Routing Key: {txtDeclareRoutingKey.Text}");
        }
    }
}
