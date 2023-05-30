
namespace Sessia1Gurovskiy
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.sessionDataSet = new Sessia1Gurovskiy.SessionDataSet();
            this.tovar_importBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovar_importTableAdapter = new Sessia1Gurovskiy.SessionDataSetTableAdapters.Tovar_importTableAdapter();
            this.tableAdapterManager = new Sessia1Gurovskiy.SessionDataSetTableAdapters.TableAdapterManager();
            this.tovar_importBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tovar_importBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.sessionDataSet2 = new Sessia1Gurovskiy.SessionDataSet2();
            this.tovars_import_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovars_import_TableAdapter = new Sessia1Gurovskiy.SessionDataSet2TableAdapters.Tovars_import_TableAdapter();
            this.tableAdapterManager1 = new Sessia1Gurovskiy.SessionDataSet2TableAdapters.TableAdapterManager();
            this.tovars_import_DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovar_importBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovar_importBindingNavigator)).BeginInit();
            this.tovar_importBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovars_import_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovars_import_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sessionDataSet
            // 
            this.sessionDataSet.DataSetName = "SessionDataSet";
            this.sessionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tovar_importBindingSource
            // 
            this.tovar_importBindingSource.DataMember = "Tovar_import";
            this.tovar_importBindingSource.DataSource = this.sessionDataSet;
            // 
            // tovar_importTableAdapter
            // 
            this.tovar_importTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tovar_importTableAdapter = this.tovar_importTableAdapter;
            this.tableAdapterManager.UpdateOrder = Sessia1Gurovskiy.SessionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // tovar_importBindingNavigator
            // 
            this.tovar_importBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tovar_importBindingNavigator.BindingSource = this.tovar_importBindingSource;
            this.tovar_importBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tovar_importBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tovar_importBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tovar_importBindingNavigatorSaveItem});
            this.tovar_importBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tovar_importBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tovar_importBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tovar_importBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tovar_importBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tovar_importBindingNavigator.Name = "tovar_importBindingNavigator";
            this.tovar_importBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tovar_importBindingNavigator.Size = new System.Drawing.Size(1007, 25);
            this.tovar_importBindingNavigator.TabIndex = 0;
            this.tovar_importBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tovar_importBindingNavigatorSaveItem
            // 
            this.tovar_importBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tovar_importBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tovar_importBindingNavigatorSaveItem.Image")));
            this.tovar_importBindingNavigatorSaveItem.Name = "tovar_importBindingNavigatorSaveItem";
            this.tovar_importBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tovar_importBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tovar_importBindingNavigatorSaveItem.Click += new System.EventHandler(this.tovar_importBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(392, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Краткий список товара";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sessionDataSet2
            // 
            this.sessionDataSet2.DataSetName = "SessionDataSet2";
            this.sessionDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tovars_import_BindingSource
            // 
            this.tovars_import_BindingSource.DataMember = "Tovars_import$";
            this.tovars_import_BindingSource.DataSource = this.sessionDataSet2;
            // 
            // tovars_import_TableAdapter
            // 
            this.tovars_import_TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Tovars_import_TableAdapter = this.tovars_import_TableAdapter;
            this.tableAdapterManager1.UpdateOrder = Sessia1Gurovskiy.SessionDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UserTableAdapter = null;
            // 
            // tovars_import_DataGridView
            // 
            this.tovars_import_DataGridView.AutoGenerateColumns = false;
            this.tovars_import_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tovars_import_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.tovars_import_DataGridView.DataSource = this.tovars_import_BindingSource;
            this.tovars_import_DataGridView.Location = new System.Drawing.Point(12, 28);
            this.tovars_import_DataGridView.Name = "tovars_import_DataGridView";
            this.tovars_import_DataGridView.Size = new System.Drawing.Size(1234, 423);
            this.tovars_import_DataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Артикул";
            this.dataGridViewTextBoxColumn1.HeaderText = "Артикул";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Единица измерения\r\nЕдиница измерения";
            this.dataGridViewTextBoxColumn3.HeaderText = "Единица измерения\r\nЕдиница измерения";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Стоимость";
            this.dataGridViewTextBoxColumn4.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Размер максимально возможной скидки";
            this.dataGridViewTextBoxColumn5.HeaderText = "Размер максимально возможной скидки";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Производитель";
            this.dataGridViewTextBoxColumn6.HeaderText = "Производитель";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Поставщик";
            this.dataGridViewTextBoxColumn7.HeaderText = "Поставщик";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Категория товара";
            this.dataGridViewTextBoxColumn8.HeaderText = "Категория товара";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Действующая скидка";
            this.dataGridViewTextBoxColumn9.HeaderText = "Действующая скидка";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Кол-во на складе";
            this.dataGridViewTextBoxColumn10.HeaderText = "Кол-во на складе";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Описание";
            this.dataGridViewTextBoxColumn11.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Изображение";
            this.dataGridViewTextBoxColumn12.HeaderText = "Изображение";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1007, 528);
            this.Controls.Add(this.tovars_import_DataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tovar_importBindingNavigator);
            this.Name = "Form3";
            this.Text = "Целый просмотр товара";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sessionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovar_importBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovar_importBindingNavigator)).EndInit();
            this.tovar_importBindingNavigator.ResumeLayout(false);
            this.tovar_importBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovars_import_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovars_import_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SessionDataSet sessionDataSet;
        private System.Windows.Forms.BindingSource tovar_importBindingSource;
        private SessionDataSetTableAdapters.Tovar_importTableAdapter tovar_importTableAdapter;
        private SessionDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tovar_importBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tovar_importBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button1;
        private SessionDataSet2 sessionDataSet2;
        private System.Windows.Forms.BindingSource tovars_import_BindingSource;
        private SessionDataSet2TableAdapters.Tovars_import_TableAdapter tovars_import_TableAdapter;
        private SessionDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView tovars_import_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}