﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsulta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnChildCons = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnChat = New System.Windows.Forms.Button()
        Me.btnConsul = New System.Windows.Forms.Button()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.pnChildCons.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(223, -126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(374, 39)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "INGRESE SUS SINTOMAS"
        '
        'pnChildCons
        '
        Me.pnChildCons.Controls.Add(Me.Label2)
        Me.pnChildCons.Controls.Add(Me.Panel4)
        Me.pnChildCons.Controls.Add(Me.btnChat)
        Me.pnChildCons.Controls.Add(Me.btnConsul)
        Me.pnChildCons.Controls.Add(Me.ComboBox6)
        Me.pnChildCons.Controls.Add(Me.ComboBox3)
        Me.pnChildCons.Controls.Add(Me.ComboBox5)
        Me.pnChildCons.Controls.Add(Me.ComboBox4)
        Me.pnChildCons.Controls.Add(Me.ComboBox2)
        Me.pnChildCons.Controls.Add(Me.ComboBox1)
        Me.pnChildCons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnChildCons.Location = New System.Drawing.Point(0, 0)
        Me.pnChildCons.Name = "pnChildCons"
        Me.pnChildCons.Size = New System.Drawing.Size(778, 699)
        Me.pnChildCons.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(169, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(365, 36)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Selecciones sus sintoams"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(11, 451)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(757, 225)
        Me.Panel4.TabIndex = 25
        '
        'btnChat
        '
        Me.btnChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnChat.FlatAppearance.BorderSize = 0
        Me.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChat.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChat.Location = New System.Drawing.Point(535, 394)
        Me.btnChat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnChat.Name = "btnChat"
        Me.btnChat.Size = New System.Drawing.Size(233, 49)
        Me.btnChat.TabIndex = 23
        Me.btnChat.Text = "CHAT"
        Me.btnChat.UseVisualStyleBackColor = False
        '
        'btnConsul
        '
        Me.btnConsul.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnConsul.FlatAppearance.BorderSize = 0
        Me.btnConsul.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsul.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsul.Location = New System.Drawing.Point(11, 394)
        Me.btnConsul.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConsul.Name = "btnConsul"
        Me.btnConsul.Size = New System.Drawing.Size(233, 49)
        Me.btnConsul.TabIndex = 28
        Me.btnConsul.Text = "CONSULTAR"
        Me.btnConsul.UseVisualStyleBackColor = False
        '
        'ComboBox6
        '
        Me.ComboBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ComboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox6.ForeColor = System.Drawing.Color.Silver
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(523, 207)
        Me.ComboBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(233, 24)
        Me.ComboBox6.TabIndex = 27
        Me.ComboBox6.Text = "SINTOMA"
        '
        'ComboBox3
        '
        Me.ComboBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.ForeColor = System.Drawing.Color.Silver
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(523, 82)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(233, 24)
        Me.ComboBox3.TabIndex = 22
        Me.ComboBox3.Text = "SINTOMA"
        '
        'ComboBox5
        '
        Me.ComboBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ComboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.ForeColor = System.Drawing.Color.Silver
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(261, 207)
        Me.ComboBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(233, 24)
        Me.ComboBox5.TabIndex = 26
        Me.ComboBox5.Text = "SINTOMA"
        '
        'ComboBox4
        '
        Me.ComboBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.ForeColor = System.Drawing.Color.Silver
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(11, 207)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(233, 24)
        Me.ComboBox4.TabIndex = 24
        Me.ComboBox4.Text = "SINTOMA"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.ForeColor = System.Drawing.Color.Silver
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(261, 82)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(233, 24)
        Me.ComboBox2.TabIndex = 21
        Me.ComboBox2.Text = "SINTOMA"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Silver
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(11, 82)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(233, 24)
        Me.ComboBox1.TabIndex = 20
        Me.ComboBox1.Text = "SINTOMA"
        '
        'FrmConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(778, 699)
        Me.Controls.Add(Me.pnChildCons)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmConsulta"
        Me.Text = "Consulta"
        Me.pnChildCons.ResumeLayout(False)
        Me.pnChildCons.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents pnChildCons As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnChat As Button
    Friend WithEvents btnConsul As Button
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
