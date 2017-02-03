using Sipek.Common;

namespace TestSoftphone
{
	internal class AccountConfig : IAccount
	{
		private const string EXTEN = "5000";
		private const string PASSWORD = "";

		public string AccountName
		{
			get
			{
				return EXTEN;
			}

			set { }
		}

		public string DisplayName
		{
			get
			{
				return EXTEN;
			}

			set { }
		}

		public string DomainName
		{
			get
			{
				return "*";
			}

			set { }
		}

		public bool Enabled
		{
			get
			{
				return true;
			}

			set { }
		}

		public string HostName
		{
			get
			{
				return "";
            }

			set { }
		}

		public string Id
		{
			get
			{
				return EXTEN;
			}

			set { }
		}

		public int Index
		{
			get
			{
				return 0;
			}

			set { }
		}

		public string Password
		{
			get
			{
				return PASSWORD;
            }

			set { }
		}

		public string ProxyAddress
		{
			get
			{
				return string.Empty;
			}

			set { }
		}

		public int RegState
		{
			get
			{
				return 0;
			}

			set { }
		}

		public ETransportMode TransportMode
		{
			get
			{
				return ETransportMode.TM_UDP;
			}

			set { }
		}

		public string UserName
		{
			get
			{
				return EXTEN;
			}

			set { }
		}
	}
}
