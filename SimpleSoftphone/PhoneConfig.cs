using System;
using System.Collections.Generic;
using Sipek.Common;

namespace TestSoftphone
{
	internal class PhoneConfig : IConfiguratorInterface
	{
		List<IAccount> acclist = new List<IAccount>();

		internal PhoneConfig()
		{
			acclist.Add(new AccountConfig());
		}


		public bool AAFlag
		{
			get
			{
				return false;
			}

			set { }
		}

		public List<IAccount> Accounts
		{
			get
			{
				return acclist;
            }
		}

		public bool CFBFlag
		{
			get
			{
				return false;
			}

			set	{ }
		}

		public string CFBNumber
		{
			get
			{
				return string.Empty;
			}

			set { }
		}

		public bool CFNRFlag
		{
			get
			{
				return false;
			}

			set { }
		}

		public string CFNRNumber
		{
			get
			{
				return string.Empty;
			}

			set { }
		}

		public bool CFUFlag
		{
			get
			{
				return false;
			}

			set { }
		}

		public string CFUNumber
		{
			get
			{
				return string.Empty;
			}

			set { }
		}

		public List<string> CodecList
		{
			get
			{
				var slCodecs = new List<string>();
				slCodecs.Add("PCMA");
				return slCodecs;
			}

			set { }
		}

		public int DefaultAccountIndex
		{
			get
			{
				return 0;
			}
		}

		public bool DNDFlag
		{
			get
			{
				return false;
			}

			set { }
		}

		public bool IsNull
		{
			get
			{
				return false;
			}
		}

		public bool PublishEnabled
		{
			get
			{
				return false;
			}

			set { }
		}

		public int SIPPort
		{
			get
			{
				return 5060;
			}

			set { }
		}

		public void Save()
		{
			throw new NotImplementedException();
		}
	}
}
