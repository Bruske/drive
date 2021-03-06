﻿using DigoFramework;
using Drive.Server;
using Drive.Server.WebSocket;
using NetZ.Web;
using NetZ.Web.Server;
using System.Collections.Generic;

namespace Drive
{
    internal class AppDrive : AppWebBase
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private static AppDrive _i;

        public new static AppDrive i
        {
            get
            {
                if (_i != null)
                {
                    return _i;
                }

                _i = new AppDrive();

                return _i;
            }
        }

        #endregion Atributos

        #region Construtores

        private AppDrive() : base("Drive")
        {
        }

        #endregion Construtores

        #region Métodos

        protected override ConfigWebBase getObjConfig()
        {
            return ConfigDrive.i;
        }

        protected override TemaBase getObjTema()
        {
            return new TemaDrive();
        }

        protected override void inicializarLstSrv(List<ServerBase> lstSrv)
        {
            lstSrv.Add(new SrvHttpDrive());

            lstSrv.Add(SrvWsDrive.i);
        }

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}