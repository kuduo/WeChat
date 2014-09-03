using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HD.WeChat.API.Entities
{
	public class ResponseMessageTransfer_Customer_Service : ResponseMessageBase, IResponseMessageBase
	{
		new public virtual ResponseMsgType MsgType
		{
			get { return ResponseMsgType.Transfer_Customer_Service; }
		}
	}
}