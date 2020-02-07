<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.name_export = New System.Windows.Forms.Label()
        Me.age_export = New System.Windows.Forms.Label()
        Me.address_export = New System.Windows.Forms.Label()
        Me.fullname = New System.Windows.Forms.TextBox()
        Me.age = New System.Windows.Forms.TextBox()
        Me.address = New System.Windows.Forms.TextBox()
        Me.export_text = New System.Windows.Forms.Button()
        Me.xml_export = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'name_export
        '
        Me.name_export.AutoSize = True
        Me.name_export.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.name_export.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_export.Location = New System.Drawing.Point(104, 96)
        Me.name_export.Name = "name_export"
        Me.name_export.Size = New System.Drawing.Size(73, 29)
        Me.name_export.TabIndex = 0
        Me.name_export.Text = "NAME"
        '
        'age_export
        '
        Me.age_export.AutoSize = True
        Me.age_export.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.age_export.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.age_export.Location = New System.Drawing.Point(104, 139)
        Me.age_export.Name = "age_export"
        Me.age_export.Size = New System.Drawing.Size(54, 29)
        Me.age_export.TabIndex = 1
        Me.age_export.Text = "AGE"
        '
        'address_export
        '
        Me.address_export.AutoSize = True
        Me.address_export.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.address_export.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address_export.Location = New System.Drawing.Point(104, 185)
        Me.address_export.Name = "address_export"
        Me.address_export.Size = New System.Drawing.Size(108, 29)
        Me.address_export.TabIndex = 2
        Me.address_export.Text = "ADDRESS"
        '
        'fullname
        '
        Me.fullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullname.Location = New System.Drawing.Point(222, 95)
        Me.fullname.Name = "fullname"
        Me.fullname.Size = New System.Drawing.Size(336, 30)
        Me.fullname.TabIndex = 3
        '
        'age
        '
        Me.age.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.age.Location = New System.Drawing.Point(222, 139)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(336, 30)
        Me.age.TabIndex = 4
        '
        'address
        '
        Me.address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.Location = New System.Drawing.Point(222, 184)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(336, 30)
        Me.address.TabIndex = 5
        '
        'export_text
        '
        Me.export_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.export_text.Location = New System.Drawing.Point(159, 238)
        Me.export_text.Name = "export_text"
        Me.export_text.Size = New System.Drawing.Size(97, 54)
        Me.export_text.TabIndex = 6
        Me.export_text.Text = "Export as .txt file"
        Me.export_text.UseVisualStyleBackColor = True
        '
        'xml_export
        '
        Me.xml_export.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xml_export.Location = New System.Drawing.Point(276, 238)
        Me.xml_export.Name = "xml_export"
        Me.xml_export.Size = New System.Drawing.Size(97, 54)
        Me.xml_export.TabIndex = 7
        Me.xml_export.Text = "Export as .xml file"
        Me.xml_export.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(392, 239)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 54)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Export as .json file"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(632, 401)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.xml_export)
        Me.Controls.Add(Me.export_text)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.fullname)
        Me.Controls.Add(Me.address_export)
        Me.Controls.Add(Me.age_export)
        Me.Controls.Add(Me.name_export)
        Me.Name = "Form1"
        Me.Text = "Simple Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents name_export As Label
    Friend WithEvents age_export As Label
    Friend WithEvents address_export As Label
    Friend WithEvents fullname As TextBox
    Friend WithEvents age As TextBox
    Friend WithEvents address As TextBox
    Friend WithEvents export_text As Button
    Friend WithEvents xml_export As Button
    Friend WithEvents Button2 As Button
End Class
