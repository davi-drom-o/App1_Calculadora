<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.num1 = New System.Windows.Forms.TextBox()
        Me.mas = New System.Windows.Forms.Button()
        Me.Numero1 = New System.Windows.Forms.Label()
        Me.num2 = New System.Windows.Forms.TextBox()
        Me.Numero2 = New System.Windows.Forms.Label()
        Me.resultado = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.menos = New System.Windows.Forms.Button()
        Me.entre = New System.Windows.Forms.Button()
        Me.por = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'num1
        '
        Me.num1.Location = New System.Drawing.Point(222, 71)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(228, 20)
        Me.num1.TabIndex = 0
        Me.num1.Text = "0"
        '
        'mas
        '
        Me.mas.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mas.Location = New System.Drawing.Point(709, 19)
        Me.mas.Name = "mas"
        Me.mas.Size = New System.Drawing.Size(70, 72)
        Me.mas.TabIndex = 1
        Me.mas.Text = "+"
        Me.mas.UseVisualStyleBackColor = True
        '
        'Numero1
        '
        Me.Numero1.AutoSize = True
        Me.Numero1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numero1.Location = New System.Drawing.Point(52, 68)
        Me.Numero1.Name = "Numero1"
        Me.Numero1.Size = New System.Drawing.Size(147, 29)
        Me.Numero1.TabIndex = 2
        Me.Numero1.Text = "NUMERO 1"
        '
        'num2
        '
        Me.num2.Location = New System.Drawing.Point(222, 147)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(228, 20)
        Me.num2.TabIndex = 3
        Me.num2.Text = "0"
        '
        'Numero2
        '
        Me.Numero2.AutoSize = True
        Me.Numero2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numero2.Location = New System.Drawing.Point(50, 143)
        Me.Numero2.Name = "Numero2"
        Me.Numero2.Size = New System.Drawing.Size(147, 29)
        Me.Numero2.TabIndex = 4
        Me.Numero2.Text = "NUMERO 2"
        '
        'resultado
        '
        Me.resultado.AutoSize = True
        Me.resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultado.Location = New System.Drawing.Point(50, 203)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(168, 29)
        Me.resultado.TabIndex = 5
        Me.resultado.Text = "RESULTADO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(244, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 31)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "0"
        '
        'menos
        '
        Me.menos.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menos.Location = New System.Drawing.Point(709, 97)
        Me.menos.Name = "menos"
        Me.menos.Size = New System.Drawing.Size(70, 71)
        Me.menos.TabIndex = 7
        Me.menos.Text = "-"
        Me.menos.UseVisualStyleBackColor = True
        '
        'entre
        '
        Me.entre.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.entre.Location = New System.Drawing.Point(709, 174)
        Me.entre.Name = "entre"
        Me.entre.Size = New System.Drawing.Size(66, 68)
        Me.entre.TabIndex = 8
        Me.entre.Text = "/"
        Me.entre.UseVisualStyleBackColor = True
        '
        'por
        '
        Me.por.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.por.Location = New System.Drawing.Point(706, 248)
        Me.por.Name = "por"
        Me.por.Size = New System.Drawing.Size(69, 65)
        Me.por.TabIndex = 9
        Me.por.Text = "X"
        Me.por.UseVisualStyleBackColor = True
        '
        'Button0
        '
        Me.Button0.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button0.Location = New System.Drawing.Point(581, 205)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(53, 48)
        Me.Button0.TabIndex = 10
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(522, 151)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 48)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(581, 151)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 48)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(640, 151)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(53, 48)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(522, 97)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(53, 48)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(581, 97)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(53, 48)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(640, 97)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(53, 48)
        Me.Button6.TabIndex = 16
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(522, 43)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(53, 48)
        Me.Button7.TabIndex = 17
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(581, 43)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(53, 48)
        Me.Button8.TabIndex = 18
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(640, 43)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(53, 48)
        Me.Button9.TabIndex = 19
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.Location = New System.Drawing.Point(706, 319)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(69, 65)
        Me.clear.TabIndex = 20
        Me.clear.Text = "C"
        Me.clear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button0)
        Me.Controls.Add(Me.por)
        Me.Controls.Add(Me.entre)
        Me.Controls.Add(Me.menos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.Numero2)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.Numero1)
        Me.Controls.Add(Me.mas)
        Me.Controls.Add(Me.num1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents num1 As TextBox
    Friend WithEvents mas As Button
    Friend WithEvents Numero1 As Label
    Friend WithEvents num2 As TextBox
    Friend WithEvents Numero2 As Label
    Friend WithEvents resultado As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents menos As Button
    Friend WithEvents entre As Button
    Friend WithEvents por As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents clear As Button
End Class
