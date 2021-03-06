using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.IO;
using Models;

public class Inicio : Form //Tela Inicial
{
    private System.ComponentModel.IContainer components = null;

    Label lblLogin;
    Label lblMessage;

    Button btnCategorias;
    Button btnTags;
    Button btnSenhas;
    Button btnUsuario;
    Button btnCancel;

    public Inicio()
    {
        this.MinimizeBox = false;
        this.MaximizeBox = false;
        
        Size = new Size(320, 245);
        
        this.lblMessage = new Label();
        this.lblMessage.Text = $"Olá {Usuario.UsuarioAuth.Nome}";
        this.lblMessage.Location = new Point(122, 28);

        this.btnCategorias = new Button();
        this.btnCategorias.Text = "Categorias";
        this.btnCategorias.Location = new Point(40, 70);
        this.btnCategorias.Size = new Size(100, 30);
        this.btnCategorias.Click += new EventHandler(this.handleCategoriasClick);

        this.btnTags = new Button();
        this.btnTags.Text = "Tags";
        this.btnTags.Location = new Point(160, 70);
        this.btnTags.Size = new Size(100, 30);
        this.btnTags.Click += new EventHandler(this.handleTagsClick);

        this.btnSenhas = new Button();
        this.btnSenhas.Text = "Senhas";
        this.btnSenhas.Location = new Point(40, 110);
        this.btnSenhas.Size = new Size(100, 30);
        this.btnSenhas.Click += new EventHandler(this.handleSenhasClick);

        this.btnUsuario = new Button();
        this.btnUsuario.Text = "Usuário";
        this.btnUsuario.Location = new Point(160, 110);
        this.btnUsuario.Size = new Size(100, 30);
        this.btnUsuario.Click += new EventHandler(this.handleUsuarioClick);

        this.btnCancel = new Button();
        this.btnCancel.Text = "Sair";
        this.btnCancel.Location = new Point(110, 160);
        this.btnCancel.Size = new Size(80, 30);
        this.btnCancel.Click += new EventHandler(this.handleCancelClick);
        
        this.Controls.Add(this.lblLogin);
        this.Controls.Add(this.lblMessage);
        this.Controls.Add(this.btnCategorias);
        this.Controls.Add(this.btnTags);
        this.Controls.Add(this.btnSenhas);
        this.Controls.Add(this.btnUsuario);
        this.Controls.Add(this.btnCancel);

    }

    private void handleCategoriasClick(object sender, EventArgs e)
    {
        Categorias menu = new Categorias();
        menu.ShowDialog();
    }

    private void handleTagsClick(object sender, EventArgs e)
    {
        Tags menu = new Tags();
        menu.ShowDialog();
    }

    private void handleSenhasClick(object sender, EventArgs e)
    {
        Senhas menu = new Senhas();
        menu.ShowDialog();
    }

    private void handleUsuarioClick(object sender, EventArgs e)
    {
        Usuarios menu = new Usuarios();
        menu.ShowDialog();
    }
    
    private void handleCancelClick(object sender, EventArgs e)
    {
        this.Close();
    }
}