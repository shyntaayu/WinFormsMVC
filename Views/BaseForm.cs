using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMVC.Controllers;

namespace WinFormsMVC.Views
{
    public abstract partial class BaseForm : Form
    {
        // Protected members untuk diakses child class
        protected string FormTitle { get; set; }

        // Constructor
        protected BaseForm()
        {
            InitializeBaseForm();
        }

        // Virtual method yang bisa di-override (Polymorphism)
        protected virtual void InitializeBaseForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        // Common method untuk show messages
        protected void ShowSuccess(string message, string title = "Sukses")
        {
            MessageBox.Show(message, title,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected void ShowError(string message, string title = "Error")
        {
            MessageBox.Show(message, title,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected void ShowWarning(string message, string title = "Peringatan")
        {
            MessageBox.Show(message, title,
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        protected DialogResult ShowConfirmation(string message, string title = "Konfirmasi")
        {
            return MessageBox.Show(message, title,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        // Common method untuk validasi
        protected bool ValidateNotEmpty(TextBox textBox, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                ShowWarning($"{fieldName} tidak boleh kosong!");
                textBox.Focus();
                return false;
            }
            return true;
        }

        protected bool ValidateNumeric(TextBox textBox, string fieldName, out double value)
        {
            if (!double.TryParse(textBox.Text, out value))
            {
                ShowWarning($"{fieldName} harus berupa angka!");
                textBox.Focus();
                return false;
            }
            return true;
        }

        protected bool ValidateRange(double value, double min, double max, string fieldName)
        {
            if (value < min || value > max)
            {
                ShowWarning($"{fieldName} harus antara {min} - {max}!");
                return false;
            }
            return true;
        }

        // Abstract method yang harus diimplementasikan child class
        protected abstract void LoadData();
        protected abstract void ClearForm();

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        components?.Dispose();
        //        _controller?.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        // Generic method untuk handle operation result (DRY Principle)
        protected void HandleResult<T>(OperationResult<T> result, Action<T> onSuccess)
        {
            if (result.IsSuccess)
            {
                onSuccess?.Invoke(result.Data);
            }
            else
            {
                ShowError(result.Message);
            }
        }
    }
}