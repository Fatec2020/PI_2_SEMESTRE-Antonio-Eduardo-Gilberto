
namespace PI_QSV
{
    partial class Visitantes
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
            System.Windows.Forms.Label iD_VISITANTELabel;
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label tELEFONELabel;
            System.Windows.Forms.Label nOME_RESPONSAVEL_ESTADIALabel;
            System.Windows.Forms.Label pLACA_VEICULOLabel;
            System.Windows.Forms.Label mODELOLabel;
            System.Windows.Forms.Label aNOLabel;
            System.Windows.Forms.Label cORLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visitantes));
            this.dB_PIDataSet = new PI_QSV.DB_PIDataSet();
            this.tB_VISITANTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_VISITANTESTableAdapter = new PI_QSV.DB_PIDataSetTableAdapters.TB_VISITANTESTableAdapter();
            this.tableAdapterManager = new PI_QSV.DB_PIDataSetTableAdapters.TableAdapterManager();
            this.tB_VISITANTESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tB_VISITANTESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_VISITANTETextBox = new System.Windows.Forms.TextBox();
            this.nOMETextBox = new System.Windows.Forms.TextBox();
            this.cPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rGTextBox = new System.Windows.Forms.TextBox();
            this.tELEFONEMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nOME_RESPONSAVEL_ESTADIATextBox = new System.Windows.Forms.TextBox();
            this.pLACA_VEICULOMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.mODELOTextBox = new System.Windows.Forms.TextBox();
            this.aNOTextBox = new System.Windows.Forms.TextBox();
            this.cORTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btvoltar = new System.Windows.Forms.Button();
            iD_VISITANTELabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            tELEFONELabel = new System.Windows.Forms.Label();
            nOME_RESPONSAVEL_ESTADIALabel = new System.Windows.Forms.Label();
            pLACA_VEICULOLabel = new System.Windows.Forms.Label();
            mODELOLabel = new System.Windows.Forms.Label();
            aNOLabel = new System.Windows.Forms.Label();
            cORLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_VISITANTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_VISITANTESBindingNavigator)).BeginInit();
            this.tB_VISITANTESBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_VISITANTELabel
            // 
            iD_VISITANTELabel.AutoSize = true;
            iD_VISITANTELabel.BackColor = System.Drawing.Color.Transparent;
            iD_VISITANTELabel.Location = new System.Drawing.Point(13, 92);
            iD_VISITANTELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iD_VISITANTELabel.Name = "iD_VISITANTELabel";
            iD_VISITANTELabel.Size = new System.Drawing.Size(94, 20);
            iD_VISITANTELabel.TabIndex = 1;
            iD_VISITANTELabel.Text = "ID VISITANTE:";
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.BackColor = System.Drawing.Color.Transparent;
            nOMELabel.Location = new System.Drawing.Point(211, 92);
            nOMELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(52, 20);
            nOMELabel.TabIndex = 3;
            nOMELabel.Text = "NOME:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.BackColor = System.Drawing.Color.Transparent;
            cPFLabel.Location = new System.Drawing.Point(13, 140);
            cPFLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(39, 20);
            cPFLabel.TabIndex = 5;
            cPFLabel.Text = "CPF:";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.BackColor = System.Drawing.Color.Transparent;
            rGLabel.Location = new System.Drawing.Point(211, 140);
            rGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(32, 20);
            rGLabel.TabIndex = 7;
            rGLabel.Text = "RG:";
            // 
            // tELEFONELabel
            // 
            tELEFONELabel.AutoSize = true;
            tELEFONELabel.BackColor = System.Drawing.Color.Transparent;
            tELEFONELabel.Location = new System.Drawing.Point(409, 140);
            tELEFONELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tELEFONELabel.Name = "tELEFONELabel";
            tELEFONELabel.Size = new System.Drawing.Size(81, 20);
            tELEFONELabel.TabIndex = 9;
            tELEFONELabel.Text = "TELEFONE:";
            // 
            // nOME_RESPONSAVEL_ESTADIALabel
            // 
            nOME_RESPONSAVEL_ESTADIALabel.AutoSize = true;
            nOME_RESPONSAVEL_ESTADIALabel.BackColor = System.Drawing.Color.Transparent;
            nOME_RESPONSAVEL_ESTADIALabel.Location = new System.Drawing.Point(13, 189);
            nOME_RESPONSAVEL_ESTADIALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nOME_RESPONSAVEL_ESTADIALabel.Name = "nOME_RESPONSAVEL_ESTADIALabel";
            nOME_RESPONSAVEL_ESTADIALabel.Size = new System.Drawing.Size(213, 20);
            nOME_RESPONSAVEL_ESTADIALabel.TabIndex = 11;
            nOME_RESPONSAVEL_ESTADIALabel.Text = "NOME RESPONSAVEL ESTADIA:";
            // 
            // pLACA_VEICULOLabel
            // 
            pLACA_VEICULOLabel.AutoSize = true;
            pLACA_VEICULOLabel.BackColor = System.Drawing.Color.Transparent;
            pLACA_VEICULOLabel.Location = new System.Drawing.Point(13, 240);
            pLACA_VEICULOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pLACA_VEICULOLabel.Name = "pLACA_VEICULOLabel";
            pLACA_VEICULOLabel.Size = new System.Drawing.Size(116, 20);
            pLACA_VEICULOLabel.TabIndex = 13;
            pLACA_VEICULOLabel.Text = "PLACA VEICULO:";
            // 
            // mODELOLabel
            // 
            mODELOLabel.AutoSize = true;
            mODELOLabel.BackColor = System.Drawing.Color.Transparent;
            mODELOLabel.Location = new System.Drawing.Point(264, 240);
            mODELOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mODELOLabel.Name = "mODELOLabel";
            mODELOLabel.Size = new System.Drawing.Size(69, 20);
            mODELOLabel.TabIndex = 15;
            mODELOLabel.Text = "MODELO:";
            // 
            // aNOLabel
            // 
            aNOLabel.AutoSize = true;
            aNOLabel.BackColor = System.Drawing.Color.Transparent;
            aNOLabel.Location = new System.Drawing.Point(475, 240);
            aNOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            aNOLabel.Name = "aNOLabel";
            aNOLabel.Size = new System.Drawing.Size(41, 20);
            aNOLabel.TabIndex = 17;
            aNOLabel.Text = "ANO:";
            // 
            // cORLabel
            // 
            cORLabel.AutoSize = true;
            cORLabel.BackColor = System.Drawing.Color.Transparent;
            cORLabel.Location = new System.Drawing.Point(649, 240);
            cORLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cORLabel.Name = "cORLabel";
            cORLabel.Size = new System.Drawing.Size(41, 20);
            cORLabel.TabIndex = 19;
            cORLabel.Text = "COR:";
            // 
            // dB_PIDataSet
            // 
            this.dB_PIDataSet.DataSetName = "DB_PIDataSet";
            this.dB_PIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_VISITANTESBindingSource
            // 
            this.tB_VISITANTESBindingSource.DataMember = "TB_VISITANTES";
            this.tB_VISITANTESBindingSource.DataSource = this.dB_PIDataSet;
            // 
            // tB_VISITANTESTableAdapter
            // 
            this.tB_VISITANTESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TB_MORADORESTableAdapter = null;
            this.tableAdapterManager.TB_TERCEIROSTableAdapter = null;
            this.tableAdapterManager.TB_VISITANTESTableAdapter = this.tB_VISITANTESTableAdapter;
            this.tableAdapterManager.UpdateOrder = PI_QSV.DB_PIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tB_VISITANTESBindingNavigator
            // 
            this.tB_VISITANTESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tB_VISITANTESBindingNavigator.BindingSource = this.tB_VISITANTESBindingSource;
            this.tB_VISITANTESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tB_VISITANTESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tB_VISITANTESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tB_VISITANTESBindingNavigatorSaveItem});
            this.tB_VISITANTESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tB_VISITANTESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tB_VISITANTESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tB_VISITANTESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tB_VISITANTESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tB_VISITANTESBindingNavigator.Name = "tB_VISITANTESBindingNavigator";
            this.tB_VISITANTESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tB_VISITANTESBindingNavigator.Size = new System.Drawing.Size(830, 25);
            this.tB_VISITANTESBindingNavigator.TabIndex = 0;
            this.tB_VISITANTESBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
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
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tB_VISITANTESBindingNavigatorSaveItem
            // 
            this.tB_VISITANTESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tB_VISITANTESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tB_VISITANTESBindingNavigatorSaveItem.Image")));
            this.tB_VISITANTESBindingNavigatorSaveItem.Name = "tB_VISITANTESBindingNavigatorSaveItem";
            this.tB_VISITANTESBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tB_VISITANTESBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tB_VISITANTESBindingNavigatorSaveItem.Click += new System.EventHandler(this.tB_VISITANTESBindingNavigatorSaveItem_Click);
            // 
            // iD_VISITANTETextBox
            // 
            this.iD_VISITANTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_VISITANTESBindingSource, "ID_VISITANTE", true));
            this.iD_VISITANTETextBox.Location = new System.Drawing.Point(115, 89);
            this.iD_VISITANTETextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iD_VISITANTETextBox.Name = "iD_VISITANTETextBox";
            this.iD_VISITANTETextBox.Size = new System.Drawing.Size(64, 26);
            this.iD_VISITANTETextBox.TabIndex = 2;
            // 
            // nOMETextBox
            // 
            this.nOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_VISITANTESBindingSource, "NOME", true));
            this.nOMETextBox.Location = new System.Drawing.Point(271, 89);
            this.nOMETextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nOMETextBox.Name = "nOMETextBox";
            this.nOMETextBox.Size = new System.Drawing.Size(522, 26);
            this.nOMETextBox.TabIndex = 4;
            // 
            // cPFMaskedTextBox
            // 
            this.cPFMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_VISITANTESBindingSource, "CPF", true));
            this.cPFMaskedTextBox.Location = new System.Drawing.Point(60, 137);
            this.cPFMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cPFMaskedTextBox.Mask = "000,000,000-00";
            this.cPFMaskedTextBox.Name = "cPFMaskedTextBox";
            this.cPFMaskedTextBox.Size = new System.Drawing.Size(132, 26);
            this.cPFMaskedTextBox.TabIndex = 6;
            this.cPFMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rGTextBox
            // 
            this.rGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_VISITANTESBindingSource, "RG", true));
            this.rGTextBox.Location = new System.Drawing.Point(251, 137);
            this.rGTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rGTextBox.Name = "rGTextBox";
            this.rGTextBox.Size = new System.Drawing.Size(132, 26);
            this.rGTextBox.TabIndex = 8;
            // 
            // tELEFONEMaskedTextBox
            // 
            this.tELEFONEMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_VISITANTESBindingSource, "TELEFONE", true));
            this.tELEFONEMaskedTextBox.Location = new System.Drawing.Point(498, 137);
            this.tELEFONEMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tELEFONEMaskedTextBox.Mask = "(00)00000-0000";
            this.tELEFONEMaskedTextBox.Name = "tELEFONEMaskedTextBox";
            this.tELEFONEMaskedTextBox.Size = new System.Drawing.Size(132, 26);
            this.tELEFONEMaskedTextBox.TabIndex = 10;
            this.tELEFONEMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nOME_RESPONSAVEL_ESTADIATextBox
            // 
            this.nOME_RESPONSAVEL_ESTADIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_VISITANTESBindingSource, "NOME_RESPONSAVEL_ESTADIA", true));
            this.nOME_RESPONSAVEL_ESTADIATextBox.Location = new System.Drawing.Point(234, 186);
            this.nOME_RESPONSAVEL_ESTADIATextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nOME_RESPONSAVEL_ESTADIATextBox.Name = "nOME_RESPONSAVEL_ESTADIATextBox";
            this.nOME_RESPONSAVEL_ESTADIATextBox.Size = new System.Drawing.Size(132, 26);
            this.nOME_RESPONSAVEL_ESTADIATextBox.TabIndex = 12;
            // 
            // pLACA_VEICULOMaskedTextBox
            // 
            this.pLACA_VEICULOMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_VISITANTESBindingSource, "PLACA_VEICULO", true));
            this.pLACA_VEICULOMaskedTextBox.Location = new System.Drawing.Point(137, 237);
            this.pLACA_VEICULOMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pLACA_VEICULOMaskedTextBox.Mask = "AAA-0000";
            this.pLACA_VEICULOMaskedTextBox.Name = "pLACA_VEICULOMaskedTextBox";
            this.pLACA_VEICULOMaskedTextBox.Size = new System.Drawing.Size(80, 26);
            this.pLACA_VEICULOMaskedTextBox.TabIndex = 14;
            this.pLACA_VEICULOMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mODELOTextBox
            // 
            this.mODELOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_VISITANTESBindingSource, "MODELO", true));
            this.mODELOTextBox.Location = new System.Drawing.Point(341, 237);
            this.mODELOTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mODELOTextBox.Name = "mODELOTextBox";
            this.mODELOTextBox.Size = new System.Drawing.Size(93, 26);
            this.mODELOTextBox.TabIndex = 16;
            // 
            // aNOTextBox
            // 
            this.aNOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_VISITANTESBindingSource, "ANO", true));
            this.aNOTextBox.Location = new System.Drawing.Point(524, 237);
            this.aNOTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aNOTextBox.Name = "aNOTextBox";
            this.aNOTextBox.Size = new System.Drawing.Size(79, 26);
            this.aNOTextBox.TabIndex = 18;
            // 
            // cORTextBox
            // 
            this.cORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tB_VISITANTESBindingSource, "COR", true));
            this.cORTextBox.Location = new System.Drawing.Point(698, 237);
            this.cORTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cORTextBox.Name = "cORTextBox";
            this.cORTextBox.Size = new System.Drawing.Size(95, 26);
            this.cORTextBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 37);
            this.label2.TabIndex = 33;
            this.label2.Text = "Cadastro Visitantes";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(206, 289);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(85, 26);
            this.maskedTextBox1.TabIndex = 37;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(155, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "DATA:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(498, 290);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 26);
            this.textBox1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(331, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "MOTIVO PARA ENTRADA:";
            // 
            // btvoltar
            // 
            this.btvoltar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btvoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btvoltar.FlatAppearance.BorderSize = 0;
            this.btvoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvoltar.ForeColor = System.Drawing.Color.Yellow;
            this.btvoltar.Location = new System.Drawing.Point(0, 33);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(82, 37);
            this.btvoltar.TabIndex = 38;
            this.btvoltar.Text = "Voltar";
            this.btvoltar.UseVisualStyleBackColor = false;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // Visitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 357);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(iD_VISITANTELabel);
            this.Controls.Add(this.iD_VISITANTETextBox);
            this.Controls.Add(nOMELabel);
            this.Controls.Add(this.nOMETextBox);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFMaskedTextBox);
            this.Controls.Add(rGLabel);
            this.Controls.Add(this.rGTextBox);
            this.Controls.Add(tELEFONELabel);
            this.Controls.Add(this.tELEFONEMaskedTextBox);
            this.Controls.Add(nOME_RESPONSAVEL_ESTADIALabel);
            this.Controls.Add(this.nOME_RESPONSAVEL_ESTADIATextBox);
            this.Controls.Add(pLACA_VEICULOLabel);
            this.Controls.Add(this.pLACA_VEICULOMaskedTextBox);
            this.Controls.Add(mODELOLabel);
            this.Controls.Add(this.mODELOTextBox);
            this.Controls.Add(aNOLabel);
            this.Controls.Add(this.aNOTextBox);
            this.Controls.Add(cORLabel);
            this.Controls.Add(this.cORTextBox);
            this.Controls.Add(this.tB_VISITANTESBindingNavigator);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Visitantes";
            this.Text = "Visitantes";
            this.Load += new System.EventHandler(this.Visitantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_PIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_VISITANTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_VISITANTESBindingNavigator)).EndInit();
            this.tB_VISITANTESBindingNavigator.ResumeLayout(false);
            this.tB_VISITANTESBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_PIDataSet dB_PIDataSet;
        private System.Windows.Forms.BindingSource tB_VISITANTESBindingSource;
        private DB_PIDataSetTableAdapters.TB_VISITANTESTableAdapter tB_VISITANTESTableAdapter;
        private DB_PIDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tB_VISITANTESBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tB_VISITANTESBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_VISITANTETextBox;
        private System.Windows.Forms.TextBox nOMETextBox;
        private System.Windows.Forms.MaskedTextBox cPFMaskedTextBox;
        private System.Windows.Forms.TextBox rGTextBox;
        private System.Windows.Forms.MaskedTextBox tELEFONEMaskedTextBox;
        private System.Windows.Forms.TextBox nOME_RESPONSAVEL_ESTADIATextBox;
        private System.Windows.Forms.MaskedTextBox pLACA_VEICULOMaskedTextBox;
        private System.Windows.Forms.TextBox mODELOTextBox;
        private System.Windows.Forms.TextBox aNOTextBox;
        private System.Windows.Forms.TextBox cORTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btvoltar;
    }
}