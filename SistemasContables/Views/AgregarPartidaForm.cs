﻿using Guna.UI.WinForms;
using SistemasContables.controller;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasContables.Views
{
    public partial class AgregarPartidaForm : Form
    {
        const double IVA = 0.13;

        private CuentasController cuentaController;
        private PartidasController partidasController;
        private CuentaPartidaController cuentaPartidaController;
        private List<Cuenta> listaCuenta;
        List<CuentaPartida> listaCuentasPartida;
        private Partida partida;

        private int PosicionFormX;
        private int PosicionFormY;
        private int WindowWidth;
        private int WindowHeight;
        private string fecha;
        private int libroDiario;
        private int numeroPartida;        

        public AgregarPartidaForm(PartidasController partidasController, int libroDiario, int numeroPartida, string accion)
        {
            InitializeComponent();

            llenarCuentas();

            this.partidasController = partidasController;

            this.libroDiario = libroDiario;

            fecha = FormatoFecha();
            this.numeroPartida = numeroPartida;

            VerificarAccion(accion);

            this.lblPartida.Text += this.numeroPartida;

        }

        // cierra el programa
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // maximiza la ventana
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            // obtengo la posicion de la ventana previo a maximizar la ventana
            PosicionFormX = this.Location.X;
            PosicionFormY = this.Location.Y;

            // obtengo la tamaño de la ventana previo a maximizar la ventana
            WindowWidth = this.Size.Width;
            WindowHeight = this.Size.Height;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.btnMaximizar.Visible = false;
            this.btnRestoreWindow.Visible = true;
        }

        // restaurar el tamaño de la ventana al tamaño antes de maximizar
        private void btnRestoreWindow_Click(object sender, EventArgs e)
        {
            this.Size = new Size(WindowWidth, WindowHeight);
            // devulvo a la ventana a la posicion previo a maximizar la ventana
            this.Location = new Point(PosicionFormX, PosicionFormY);
            this.btnMaximizar.Visible = true;
            this.btnRestoreWindow.Visible = false;
        }

        // minimiza la ventana
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //el metodo agrega la partida
        private void btnAgregarPartida_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescripcion.Text) && tablePartidas.Rows.Count > 1)
            {

                partida = new Partida();

                partida.Fecha = this.fecha;
                partida.Detalle = this.txtDescripcion.Text;
                partida.IdLibro = this.libroDiario;
                partida.N_Partida = this.numeroPartida;

                LlenarCuentasPartida(ref partida);

                bool existeAjusteIVA = partidasController.VerificarAjusteIVA(libroDiario);

                if (existeAjusteIVA)
                {
                    partidasController.delete(numeroPartida-1, libroDiario);
                    partida.N_Partida = numeroPartida-1;
                }

                bool resultado = partidasController.insert(partida);
                
                if(resultado)
                {
                    MessageBox.Show("Se ingreso la partida correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo ingresar la partida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                this.Close();
            }
            else
            {
                MessageBox.Show("Debe poner una descripcion de la partida\ny debe tener al menos una cuenta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // el metodo modifica la partidas y sus partidas
        private void btnEditarPartida_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Desea editar la partida seleccionada?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(txtDescripcion.Text) && tablePartidas.Rows.Count > 1)
                {

                    partida = new Partida();

                    partida.Fecha = this.fecha;
                    partida.Detalle = this.txtDescripcion.Text;
                    partida.IdLibro = this.libroDiario;
                    partida.N_Partida = this.numeroPartida;

                    LlenarCuentasPartida(ref partida);

                    this.partidasController.update(partida);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe poner una descripcion de la partida\ny debe tener al menos una cuenta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

                
        }

        //el metodo agrega una cuenta
        private void btnNuevaCuenta_Click(object sender, EventArgs e)
        {

            if(!string.IsNullOrEmpty(txtMonto.Text) && cbTipoTransaccion.SelectedIndex != 0 && cbCuenta.SelectedIndex != 0)
            {
                int index = cbCuenta.SelectedIndex - 1;

                double monto = Convert.ToDouble(txtMonto.Text);
                double ivaMonto = monto * IVA;
                double montoTotal = MontoConIVA(monto, ivaMonto);

                if (cbTipoTransaccion.SelectedItem.ToString() == "Debe")
                {
                    tablePartidas.Rows.Add("", listaCuenta[index].Codigo, listaCuenta[index].Nombre, montoTotal, "0");

                    if(cbDebito.Checked)
                    {
                        tablePartidas.Rows.Add("", "210702", "Debito Fiscal IVA", ivaMonto, "0");
                    } 
                    else if(cbCredito.Checked)
                    {
                        tablePartidas.Rows.Add("", "110601", "Credito Fiscal IVA", ivaMonto, "0");
                    }

                }
                else if (cbTipoTransaccion.SelectedItem.ToString() == "Haber")
                {
                    tablePartidas.Rows.Add("", listaCuenta[index].Codigo, listaCuenta[index].Nombre, "0", montoTotal);

                    if (cbDebito.Checked)
                    {
                        tablePartidas.Rows.Add("", "210702", "Debito Fiscal IVA", "0", ivaMonto);
                    }
                    else if (cbCredito.Checked)
                    {
                        tablePartidas.Rows.Add("", "110601", "Credito Fiscal IVA", "0", ivaMonto);
                    }
                }

                txtMonto.Text = null;

            }

            else
            {
                MessageBox.Show("Todos los campos son necesarios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



        //el metodo elimina una cuenta
        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            int fila = tablePartidas.CurrentRow.Index;

            if(fila != 0)
            {
                this.tablePartidas.Rows.RemoveAt(fila);
            }
        }

        // el metodo realiza las validaciones para txtMonto
        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // permite del 0 al 9, backspace, y punto decimal
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
                return;
            }

            // comprueba que solo sea un decimal
            if (e.KeyChar == 46)
            {
                if ((sender as GunaTextBox).Text.IndexOf(e.KeyChar) != -1 || (sender as GunaTextBox).Text.Length == 0)
                {
                    e.Handled = true;
                }

            }

        }

        // el metodo realiza las validaciones para txtBuscar
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // permite de la a-z/A-Z, backspace y space
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
                return;
            }
        }

        // el metodo busca y selecciona una cuenta de cbCuenta
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            int index = cbCuenta.FindString(txtBuscar.Text);

            cbCuenta.SelectedIndex = index;
        }

        private void dpFecha_onValueChanged(object sender, EventArgs e)
        {
            fecha = FormatoFecha();

            tablePartidas.Rows[0].Cells[0].Value = fecha;
        }

        // verifica si la accion del formulario es ingresar o editar una partida
        private void VerificarAccion(string accion)
        {
            if (accion == "ingresar")
            {
                btnEditarPartida.Visible = false;

                numeroPartida++;

                lblTitulo.Text = "Nueva Partida";

                tablePartidas.Rows.Add(fecha, "", "Partida No " + numeroPartida, "", "");
            }
            else if (accion == "editar")
            {
                btnAgregarPartida.Visible = false;

                lblTitulo.Text = "Editar Partida";

                partida = partidasController.getPartida(numeroPartida, libroDiario);

                txtDescripcion.Text = partida.Detalle;

                tablePartidas.Rows.Add(partida.Fecha, "", "Partida No " + numeroPartida, "", "");

                cuentaPartidaController = new CuentaPartidaController();

                listaCuentasPartida = cuentaPartidaController.getList(numeroPartida, libroDiario);

                foreach(CuentaPartida cuentaPartida in listaCuentasPartida)
                {
                    tablePartidas.Rows.Add("", cuentaPartida.Codigo, cuentaPartida.Nombre, cuentaPartida.Debe, cuentaPartida.Haber);
                }

                setDatePicker();

            }
            else
            {
                MessageBox.Show("Ha ocurrido un error en la accion del formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
        }

        // evalua el iva y el debito y credito fiscal para insertar la respectiva fila
        private double MontoConIVA(double monto, double ivaMonto)
        {
            double montoTotal = 0;

            montoTotal = monto;

            if(cbIncluido.Checked)
            {
                montoTotal = monto - ivaMonto;
            }

            return montoTotal;

        }


        // el metodo llena las cuentas de la partida
        private void LlenarCuentasPartida(ref Partida partida)
        {

            partida.ListaCuentasPartida = new List<CuentaPartida>();

            for (int i = 1; i < tablePartidas.Rows.Count; i++)
            {
                CuentaPartida cuentaPartida = new CuentaPartida();

                cuentaPartida.Codigo = tablePartidas.Rows[i].Cells[1].Value.ToString();
                cuentaPartida.Nombre = tablePartidas.Rows[i].Cells[2].Value.ToString();
                cuentaPartida.Debe = Convert.ToDouble(tablePartidas.Rows[i].Cells[3].Value);
                cuentaPartida.Haber = Convert.ToDouble(tablePartidas.Rows[i].Cells[4].Value);

                partida.ListaCuentasPartida.Add(cuentaPartida);
            }

        }

        // el metodo llena el combobox de cuenta
        private void llenarCuentas()
        {
            cuentaController = new CuentasController();
            listaCuenta = cuentaController.getList();

            foreach (Cuenta cuenta in listaCuenta)
            {
                cbCuenta.Items.Add(cuenta.Nombre);
            }
        }

        // devulve la fecha seleccionada en formato dd/mm/YY
        private string FormatoFecha()
        {
            string[] fechaCompleto = dpFecha.Value.ToString().Split(' ');
            return fechaCompleto[0];
        }

        //el metodo setea el DatePicker cbFecha con la fecha de la partida seleccionada para editar
        private void setDatePicker()
        {
            string[] fechaCompleta = partida.Fecha.Split('/');

            int day = Convert.ToInt32(fechaCompleta[0]);
            int month = Convert.ToInt32(fechaCompleta[1]);
            int year = Convert.ToInt32(fechaCompleta[2]);

            dpFecha.Value = new DateTime(year, month, day);
        }

        //validaciones de los checkbox

        private void cbExcento_Click(object sender, EventArgs e)
        {
            if (!cbExcento.Checked)
            {
                cbExcento.Checked = true;
            }
            if (cbMasIva.Checked)
            {
                cbMasIva.Checked = false;
            }
            if (cbIncluido.Checked)
            {
                cbIncluido.Checked = false;
            }
            if (cbDebito.Enabled)
            {
                if (cbDebito.Checked)
                {
                    cbDebito.Checked = false;
                }

                cbDebito.Enabled = false;
            }
            if (cbCredito.Enabled)
            {
                if (cbCredito.Checked)
                {
                    cbCredito.Checked = false;
                }

                cbCredito.Enabled = false;
            }
        }

        private void cbMasIva_Click(object sender, EventArgs e)
        {
            if (cbExcento.Checked)
            {
                cbExcento.Checked = false;
            }
            if (!cbMasIva.Checked)
            {
                cbMasIva.Checked = true;
            }
            if (cbIncluido.Checked)
            {
                cbIncluido.Checked = false;
            }
            if (!cbDebito.Enabled)
            {
                if (!cbDebito.Checked)
                {
                    cbDebito.Checked = true;
                }

                cbDebito.Enabled = true;
            }
            if (!cbCredito.Enabled)
            {
                cbCredito.Enabled = true;
            }
        }

        private void cbIncluido_Click(object sender, EventArgs e)
        {
            if (cbExcento.Checked)
            {
                cbExcento.Checked = false;
            }
            if (cbMasIva.Checked)
            {
                cbMasIva.Checked = false;
            }
            if (!cbIncluido.Checked)
            {
                cbIncluido.Checked = true;
            }
            if (!cbDebito.Enabled)
            {
                if (!cbDebito.Checked)
                {
                    cbDebito.Checked = true;
                }

                cbDebito.Enabled = true;
            }
            if (!cbCredito.Enabled)
            {
                cbCredito.Enabled = true;
            }
        }

        private void cbDebito_Click(object sender, EventArgs e)
        {
            if (!cbDebito.Checked)
            {
                cbDebito.Checked = true;
            }
            if (cbCredito.Checked)
            {
                cbCredito.Checked = false;
            }
        }

        private void cbCredito_Click(object sender, EventArgs e)
        {
            if (cbDebito.Checked)
            {
                cbDebito.Checked = false;
            }
            if (!cbCredito.Checked)
            {
                cbCredito.Checked = true;

            }
        }

        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

    }
}
