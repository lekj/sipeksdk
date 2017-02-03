using Sipek.Common;
using Sipek.Common.CallControl;
using System;
using System.Windows.Forms;

namespace TestSoftphone
{
	public partial class MainForm : Form
	{
		private PhoneConfig phoneConfig = new PhoneConfig();

		private IStateMachine call = null;

		private PhoneConfig PhoneConfig
		{
			get { return phoneConfig; }
		}

		private CallManager CallManager
		{
			get { return CallManager.Instance; }
		}

		public MainForm()
		{
			InitializeComponent();
        }

		private void RunSync(Action action)
		{
			if (InvokeRequired)
			{
				Invoke(action);
			}
			else
			{
				action();
			}
		}

		private void CallManager_AccountStateChanged(int iAccountId, int iAccState)
		{
			RunSync(() => RegStateBox.Text = iAccState.ToString());
		}

		private void CallManager_CallStateRefresh(int sessionId)
		{
			RunSync(() => CallStateBox.Text = CallManager[sessionId].StateId.ToString());
		}

		private void CallManager_IncomingCall(int sessionId, string number, string info)
		{
			call = CallManager[sessionId];
			RunSync(() => IncomePhoneBox.Text = number);
		}

		private void MakeCallBtn_Click(object sender, EventArgs e)
		{
			var sessionId = CallManager.CreateSmartOutboundCall(PhoneBox.Text, phoneConfig.DefaultAccountIndex);
            call = CallManager[sessionId];
		}

		private void RealeaseBtn_Click(object sender, EventArgs e)
		{
			PhoneBox.Clear();
			CallManager.OnUserRelease(call.Session);
		}

		private void TakeBtn_Click(object sender, EventArgs e)
		{
			CallManager.OnUserAnswer(call.Session);
		}

		private void StartBtn_Click(object sender, EventArgs e)
		{
			if (CallManager.IsInitialized)
			{
				CallManager.UnRegisterAccounts();
				StartBtn.Text = "START";
			}
			else
			{
				CallManager.CallStateRefresh += CallManager_CallStateRefresh;
				CallManager.AccountStateChanged += CallManager_AccountStateChanged;
				CallManager.IncomingCallNotification += CallManager_IncomingCall;
				CallManager.RegisterAccounts(phoneConfig);
				StartBtn.Text = "STOP";
			}
		}
	}
}
