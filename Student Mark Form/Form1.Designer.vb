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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DisplayStats = New System.Windows.Forms.Button()
        Me.AddResults = New System.Windows.Forms.Button()
        Me.ShowRowStats = New System.Windows.Forms.CheckBox()
        Me.StudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.English = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Maths = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Science = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentID, Me.English, Me.Maths, Me.Science})
        Me.DataGridView1.Location = New System.Drawing.Point(159, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(629, 426)
        Me.DataGridView1.TabIndex = 0
        '
        'DisplayStats
        '
        Me.DisplayStats.Location = New System.Drawing.Point(12, 109)
        Me.DisplayStats.Name = "DisplayStats"
        Me.DisplayStats.Size = New System.Drawing.Size(131, 77)
        Me.DisplayStats.TabIndex = 1
        Me.DisplayStats.Text = "Display Stats"
        Me.DisplayStats.UseVisualStyleBackColor = True
        '
        'AddResults
        '
        Me.AddResults.Location = New System.Drawing.Point(12, 12)
        Me.AddResults.Name = "AddResults"
        Me.AddResults.Size = New System.Drawing.Size(131, 78)
        Me.AddResults.TabIndex = 1
        Me.AddResults.Text = "Add Results"
        Me.AddResults.UseVisualStyleBackColor = True
        '
        'ShowRowStats
        '
        Me.ShowRowStats.AutoSize = True
        Me.ShowRowStats.Location = New System.Drawing.Point(12, 419)
        Me.ShowRowStats.Name = "ShowRowStats"
        Me.ShowRowStats.Size = New System.Drawing.Size(109, 19)
        Me.ShowRowStats.TabIndex = 2
        Me.ShowRowStats.Text = "Show Row Stats"
        Me.ShowRowStats.UseVisualStyleBackColor = True
        '
        'StudentID
        '
        Me.StudentID.Frozen = True
        Me.StudentID.HeaderText = "Student ID"
        Me.StudentID.Name = "StudentID"
        Me.StudentID.ReadOnly = True
        '
        'English
        '
        Me.English.HeaderText = "English"
        Me.English.Name = "English"
        Me.English.ReadOnly = True
        '
        'Maths
        '
        Me.Maths.HeaderText = "Maths"
        Me.Maths.Name = "Maths"
        Me.Maths.ReadOnly = True
        '
        'Science
        '
        Me.Science.HeaderText = "Science"
        Me.Science.Name = "Science"
        Me.Science.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ShowRowStats)
        Me.Controls.Add(Me.AddResults)
        Me.Controls.Add(Me.DisplayStats)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StudentID As DataGridViewTextBoxColumn
    Friend WithEvents English As DataGridViewTextBoxColumn
    Friend WithEvents Maths As DataGridViewTextBoxColumn
    Friend WithEvents Science As DataGridViewTextBoxColumn
    Friend WithEvents DisplayStats As Button
    Friend WithEvents AddResults As Button
    Friend WithEvents ShowRowStats As CheckBox
End Class
