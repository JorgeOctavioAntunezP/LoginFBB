using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topicos_Proyecto
{
    public class ServerConnection
    {
        private string _url = "http://localhost:42089/commandsHub";
        public HubConnection _connHub;

        public void Conexión() // Constructor de la Forma
        {
            // Crear la conexión al hub
            _connHub = new HubConnectionBuilder()
                .WithUrl(_url)
                .Build();

            // Configurar reconexión automática en caso de desconexión
            _connHub.Closed += async (error) =>
            {
                await Task.Delay(5000);
                await _connHub.StartAsync();
            };
        }

        public async void IniciarConexión() // Cuando se Carga la Forma
        {
            try
            {
                // Iniciar la conexión al hub
                await _connHub.StartAsync();
            }
            catch
            {
                MessageBox.Show("No se puede conectar con el servidor", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
