﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Command;

namespace SuperWebSocket.Command
{
    public class Close<TWebSocketSession> : CommandBase<TWebSocketSession, WebSocketCommandInfo>
        where TWebSocketSession : WebSocketSession<TWebSocketSession>, new()
    {
        public override string Name
        {
            get
            {
                return "8";
            }
        }

        public override void ExecuteCommand(TWebSocketSession session, WebSocketCommandInfo commandInfo)
        {
            session.Close(CloseReason.ClientClosing);
        }
    }
}
