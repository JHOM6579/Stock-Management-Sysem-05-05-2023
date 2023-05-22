<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AdminMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_ManageProducts = New System.Windows.Forms.Button()
        Me.btn_Report = New System.Windows.Forms.Button()
        Me.btnManageStock = New System.Windows.Forms.Button()
        Me.btn_ChangePassword = New System.Windows.Forms.Button()
        Me.btn_ManageUsers = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1192, 71)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Exit, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_ManageProducts, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Report, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnManageStock, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_ChangePassword, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_ManageUsers, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(435, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(757, 41)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Exit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Exit.FlatAppearance.BorderSize = 0
        Me.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.ForeColor = System.Drawing.Color.White
        Me.btn_Exit.Location = New System.Drawing.Point(633, 3)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(121, 35)
        Me.btn_Exit.TabIndex = 7
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'btn_ManageProducts
        '
        Me.btn_ManageProducts.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_ManageProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ManageProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_ManageProducts.FlatAppearance.BorderSize = 0
        Me.btn_ManageProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ManageProducts.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ManageProducts.ForeColor = System.Drawing.Color.White
        Me.btn_ManageProducts.Location = New System.Drawing.Point(3, 3)
        Me.btn_ManageProducts.Name = "btn_ManageProducts"
        Me.btn_ManageProducts.Size = New System.Drawing.Size(120, 35)
        Me.btn_ManageProducts.TabIndex = 2
        Me.btn_ManageProducts.Text = "Manage Products"
        Me.btn_ManageProducts.UseVisualStyleBackColor = False
        '
        'btn_Report
        '
        Me.btn_Report.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_Report.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Report.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Report.FlatAppearance.BorderSize = 0
        Me.btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Report.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Report.ForeColor = System.Drawing.Color.White
        Me.btn_Report.Location = New System.Drawing.Point(507, 3)
        Me.btn_Report.Name = "btn_Report"
        Me.btn_Report.Size = New System.Drawing.Size(120, 35)
        Me.btn_Report.TabIndex = 6
        Me.btn_Report.Text = "Report"
        Me.btn_Report.UseVisualStyleBackColor = False
        '
        'btnManageStock
        '
        Me.btnManageStock.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnManageStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManageStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnManageStock.FlatAppearance.BorderSize = 0
        Me.btnManageStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageStock.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageStock.ForeColor = System.Drawing.Color.White
        Me.btnManageStock.Location = New System.Drawing.Point(129, 3)
        Me.btnManageStock.Name = "btnManageStock"
        Me.btnManageStock.Size = New System.Drawing.Size(120, 35)
        Me.btnManageStock.TabIndex = 3
        Me.btnManageStock.Text = "Manage Stock"
        Me.btnManageStock.UseVisualStyleBackColor = False
        '
        'btn_ChangePassword
        '
        Me.btn_ChangePassword.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_ChangePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ChangePassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_ChangePassword.FlatAppearance.BorderSize = 0
        Me.btn_ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ChangePassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ChangePassword.ForeColor = System.Drawing.Color.White
        Me.btn_ChangePassword.Location = New System.Drawing.Point(381, 3)
        Me.btn_ChangePassword.Name = "btn_ChangePassword"
        Me.btn_ChangePassword.Size = New System.Drawing.Size(120, 35)
        Me.btn_ChangePassword.TabIndex = 5
        Me.btn_ChangePassword.Text = "Change Password"
        Me.btn_ChangePassword.UseVisualStyleBackColor = False
        '
        'btn_ManageUsers
        '
        Me.btn_ManageUsers.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_ManageUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ManageUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_ManageUsers.FlatAppearance.BorderSize = 0
        Me.btn_ManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ManageUsers.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ManageUsers.ForeColor = System.Drawing.Color.White
        Me.btn_ManageUsers.Location = New System.Drawing.Point(255, 3)
        Me.btn_ManageUsers.Name = "btn_ManageUsers"
        Me.btn_ManageUsers.Size = New System.Drawing.Size(120, 35)
        Me.btn_ManageUsers.TabIndex = 4
        Me.btn_ManageUsers.Text = "Manage Users"
        Me.btn_ManageUsers.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(50, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 32)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "S M S"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Management System"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 557)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1192, 66)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'frm_AdminMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1192, 623)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_AdminMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_AdminMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_ManageProducts As Button
    Friend WithEvents btnManageStock As Button
    Friend WithEvents btn_ManageUsers As Button
    Friend WithEvents btn_ChangePassword As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents btn_Report As Button
End Class
