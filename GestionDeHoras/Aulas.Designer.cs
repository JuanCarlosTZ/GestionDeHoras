namespace GestionDeHoras
{
    partial class Aulas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aulas));
            System.Windows.Forms.Label id_AulaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label tipo_aulaLabel;
            System.Windows.Forms.Label id_edificioLabel;
            System.Windows.Forms.Label capacidadLabel;
            System.Windows.Forms.Label cupos_ReservadosLabel;
            System.Windows.Forms.Label estadoLabel;
            this.dBUNAPECDataSet = new GestionDeHoras.DBUNAPECDataSet();
            this.aulasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aulasTableAdapter = new GestionDeHoras.DBUNAPECDataSetTableAdapters.AulasTableAdapter();
            this.tableAdapterManager = new GestionDeHoras.DBUNAPECDataSetTableAdapters.TableAdapterManager();
            this.aulasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.aulasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_AulaTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.tipo_aulaTextBox = new System.Windows.Forms.TextBox();
            this.id_edificioTextBox = new System.Windows.Forms.TextBox();
            this.capacidadTextBox = new System.Windows.Forms.TextBox();
            this.cupos_ReservadosTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            id_AulaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            tipo_aulaLabel = new System.Windows.Forms.Label();
            id_edificioLabel = new System.Windows.Forms.Label();
            capacidadLabel = new System.Windows.Forms.Label();
            cupos_ReservadosLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBUNAPECDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingNavigator)).BeginInit();
            this.aulasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dBUNAPECDataSet
            // 
            this.dBUNAPECDataSet.DataSetName = "DBUNAPECDataSet";
            this.dBUNAPECDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aulasBindingSource
            // 
            this.aulasBindingSource.DataMember = "Aulas";
            this.aulasBindingSource.DataSource = this.dBUNAPECDataSet;
            // 
            // aulasTableAdapter
            // 
            this.aulasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AulasTableAdapter = this.aulasTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CampusTableAdapter = null;
            this.tableAdapterManager.EdificiosTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.ReservacionesTableAdapter = null;
            this.tableAdapterManager.Tipo_AulasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionDeHoras.DBUNAPECDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // aulasBindingNavigator
            // 
            this.aulasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aulasBindingNavigator.BindingSource = this.aulasBindingSource;
            this.aulasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aulasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aulasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.aulasBindingNavigatorSaveItem});
            this.aulasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aulasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aulasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aulasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aulasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aulasBindingNavigator.Name = "aulasBindingNavigator";
            this.aulasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aulasBindingNavigator.Size = new System.Drawing.Size(630, 25);
            this.aulasBindingNavigator.TabIndex = 0;
            this.aulasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // aulasBindingNavigatorSaveItem
            // 
            this.aulasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aulasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aulasBindingNavigatorSaveItem.Image")));
            this.aulasBindingNavigatorSaveItem.Name = "aulasBindingNavigatorSaveItem";
            this.aulasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.aulasBindingNavigatorSaveItem.Text = "Save Data";
            this.aulasBindingNavigatorSaveItem.Click += new System.EventHandler(this.aulasBindingNavigatorSaveItem_Click);
            // 
            // id_AulaLabel
            // 
            id_AulaLabel.AutoSize = true;
            id_AulaLabel.Location = new System.Drawing.Point(12, 69);
            id_AulaLabel.Name = "id_AulaLabel";
            id_AulaLabel.Size = new System.Drawing.Size(43, 13);
            id_AulaLabel.TabIndex = 1;
            id_AulaLabel.Text = "Id Aula:";
            // 
            // id_AulaTextBox
            // 
            this.id_AulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulasBindingSource, "Id_Aula", true));
            this.id_AulaTextBox.Location = new System.Drawing.Point(118, 66);
            this.id_AulaTextBox.Name = "id_AulaTextBox";
            this.id_AulaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_AulaTextBox.TabIndex = 2;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(12, 95);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulasBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(118, 92);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // tipo_aulaLabel
            // 
            tipo_aulaLabel.AutoSize = true;
            tipo_aulaLabel.Location = new System.Drawing.Point(12, 121);
            tipo_aulaLabel.Name = "tipo_aulaLabel";
            tipo_aulaLabel.Size = new System.Drawing.Size(50, 13);
            tipo_aulaLabel.TabIndex = 5;
            tipo_aulaLabel.Text = "tipo aula:";
            // 
            // tipo_aulaTextBox
            // 
            this.tipo_aulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulasBindingSource, "tipo_aula", true));
            this.tipo_aulaTextBox.Location = new System.Drawing.Point(118, 118);
            this.tipo_aulaTextBox.Name = "tipo_aulaTextBox";
            this.tipo_aulaTextBox.Size = new System.Drawing.Size(100, 20);
            this.tipo_aulaTextBox.TabIndex = 6;
            // 
            // id_edificioLabel
            // 
            id_edificioLabel.AutoSize = true;
            id_edificioLabel.Location = new System.Drawing.Point(12, 147);
            id_edificioLabel.Name = "id_edificioLabel";
            id_edificioLabel.Size = new System.Drawing.Size(54, 13);
            id_edificioLabel.TabIndex = 7;
            id_edificioLabel.Text = "id edificio:";
            // 
            // id_edificioTextBox
            // 
            this.id_edificioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulasBindingSource, "id_edificio", true));
            this.id_edificioTextBox.Location = new System.Drawing.Point(118, 144);
            this.id_edificioTextBox.Name = "id_edificioTextBox";
            this.id_edificioTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_edificioTextBox.TabIndex = 8;
            // 
            // capacidadLabel
            // 
            capacidadLabel.AutoSize = true;
            capacidadLabel.Location = new System.Drawing.Point(12, 173);
            capacidadLabel.Name = "capacidadLabel";
            capacidadLabel.Size = new System.Drawing.Size(61, 13);
            capacidadLabel.TabIndex = 9;
            capacidadLabel.Text = "Capacidad:";
            // 
            // capacidadTextBox
            // 
            this.capacidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulasBindingSource, "Capacidad", true));
            this.capacidadTextBox.Location = new System.Drawing.Point(118, 170);
            this.capacidadTextBox.Name = "capacidadTextBox";
            this.capacidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.capacidadTextBox.TabIndex = 10;
            // 
            // cupos_ReservadosLabel
            // 
            cupos_ReservadosLabel.AutoSize = true;
            cupos_ReservadosLabel.Location = new System.Drawing.Point(12, 199);
            cupos_ReservadosLabel.Name = "cupos_ReservadosLabel";
            cupos_ReservadosLabel.Size = new System.Drawing.Size(100, 13);
            cupos_ReservadosLabel.TabIndex = 11;
            cupos_ReservadosLabel.Text = "Cupos Reservados:";
            // 
            // cupos_ReservadosTextBox
            // 
            this.cupos_ReservadosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulasBindingSource, "Cupos_Reservados", true));
            this.cupos_ReservadosTextBox.Location = new System.Drawing.Point(118, 196);
            this.cupos_ReservadosTextBox.Name = "cupos_ReservadosTextBox";
            this.cupos_ReservadosTextBox.Size = new System.Drawing.Size(100, 20);
            this.cupos_ReservadosTextBox.TabIndex = 12;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(12, 225);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 13;
            estadoLabel.Text = "Estado:";
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulasBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(118, 222);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.estadoTextBox.TabIndex = 14;
            // 
            // Aulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 304);
            this.Controls.Add(id_AulaLabel);
            this.Controls.Add(this.id_AulaTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(tipo_aulaLabel);
            this.Controls.Add(this.tipo_aulaTextBox);
            this.Controls.Add(id_edificioLabel);
            this.Controls.Add(this.id_edificioTextBox);
            this.Controls.Add(capacidadLabel);
            this.Controls.Add(this.capacidadTextBox);
            this.Controls.Add(cupos_ReservadosLabel);
            this.Controls.Add(this.cupos_ReservadosTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(this.aulasBindingNavigator);
            this.Name = "Aulas";
            this.Text = "Aulas";
            this.Load += new System.EventHandler(this.Aulas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBUNAPECDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingNavigator)).EndInit();
            this.aulasBindingNavigator.ResumeLayout(false);
            this.aulasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBUNAPECDataSet dBUNAPECDataSet;
        private System.Windows.Forms.BindingSource aulasBindingSource;
        private DBUNAPECDataSetTableAdapters.AulasTableAdapter aulasTableAdapter;
        private DBUNAPECDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aulasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton aulasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_AulaTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox tipo_aulaTextBox;
        private System.Windows.Forms.TextBox id_edificioTextBox;
        private System.Windows.Forms.TextBox capacidadTextBox;
        private System.Windows.Forms.TextBox cupos_ReservadosTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
    }
}