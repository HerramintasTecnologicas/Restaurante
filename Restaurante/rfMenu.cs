using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.ComponentModel.DataAnnotations;

namespace Restaurante
{
    public partial class rfMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public rfMenu()
        {
            InitializeComponent();
            //gridControl.DataSource = GetDataSource();
            BindingList<Customer> dataSource = GetDataSource();
            //gridControl.DataSource = dataSource;
            bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;
            timer1.Enabled = true;
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCierreCaja cierreCaja = new frmCierreCaja();
            cierreCaja.ShowDialog();
        }
        public BindingList<Customer> GetDataSource()
        {
            BindingList<Customer> result = new BindingList<Customer>();
            result.Add(new Customer()
            {
                ID = 1,
                Name = "ACME",
                Address = "2525 E El Segundo Blvd",
                City = "El Segundo",
                State = "CA",
                ZipCode = "90245",
                Phone = "(310) 536-0611"
            });
            result.Add(new Customer()
            {
                ID = 2,
                Name = "Electronics Depot",
                Address = "2455 Paces Ferry Road NW",
                City = "Atlanta",
                State = "GA",
                ZipCode = "30339",
                Phone = "(800) 595-3232"
            });
            return result;
        }
        public class Customer
        {
            [Key, Display(AutoGenerateField = false)]
            public int ID { get; set; }
            [Required]
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            [Display(Name = "Zip Code")]
            public string ZipCode { get; set; }
            public string Phone { get; set; }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmControlMesas control = new frmControlMesas();
            control.Show();
        }

        private void lblFecha_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
                lblFecha.Caption = DateTime.Now.ToString();

     
        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmInventario inventario = new frmInventario();
            inventario.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmInsumos insumos = new frmInsumos();
            insumos.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTipoUnidad unidad = new frmTipoUnidad();
            unidad.ShowDialog();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            Mesero mesero = new Mesero();
            mesero.ShowDialog();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSalidasCaja salidasCaja = new frmSalidasCaja();
            salidasCaja.ShowDialog();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCategoriaProducto producto = new frmCategoriaProducto();
            producto.ShowDialog();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPedido pedido = new frmPedido(51);
            pedido.ShowDialog();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCancelarCuentaCaja cuentaCaja = new frmCancelarCuentaCaja();
            cuentaCaja.ShowDialog();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAperturaCaja frmAperturaCaja = new frmAperturaCaja();
            frmAperturaCaja.ShowDialog();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPagosCaja pagosCaja = new frmPagosCaja();
            pagosCaja.ShowDialog();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmResumenCaja resumenCaja = new frmResumenCaja();
            resumenCaja.ShowDialog();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCambioDolar cambioDolar = new frmCambioDolar();
            cambioDolar.ShowDialog();
        }

        private void rfMenu_Load(object sender, EventArgs e)
        {

        }
    }
}