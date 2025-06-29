﻿Namespace ModelDevelopment.UserControls
    <System.ComponentModel.DefaultProperty("ParentRichTextBox")> _
    Friend Class LineNumbers_For_RichTextBox : Inherits System.Windows.Forms.Control
        Private Class LineNumberItem
            Friend LineNumber As Integer
            Friend Rectangle As Rectangle
            Friend Sub New(ByVal LineNumber As Integer, ByVal Rectangle As Rectangle)
                Me.LineNumber = LineNumber
                Me.Rectangle = Rectangle
            End Sub
        End Class
        <Flags> _
        Public Enum LineNumberDockside As Integer
            None = 0
            Left = 1
            Right = 2
            Height = 4
        End Enum
        Private withEventsField_zParent As RichTextBox = Nothing
        Private Property zParent() As RichTextBox
            Get
                Return withEventsField_zParent
            End Get
            Set(value As RichTextBox)
                If withEventsField_zParent IsNot Nothing Then
                    RemoveHandler withEventsField_zParent.LocationChanged, AddressOf zParent_Changed
                    RemoveHandler withEventsField_zParent.Move, AddressOf zParent_Changed
                    RemoveHandler withEventsField_zParent.Resize, AddressOf zParent_Changed
                    RemoveHandler withEventsField_zParent.DockChanged, AddressOf zParent_Changed
                    RemoveHandler withEventsField_zParent.TextChanged, AddressOf zParent_Changed
                    RemoveHandler withEventsField_zParent.MultilineChanged, AddressOf zParent_Changed
                    RemoveHandler withEventsField_zParent.HScroll, AddressOf zParent_Scroll
                    RemoveHandler withEventsField_zParent.VScroll, AddressOf zParent_Scroll
                    RemoveHandler withEventsField_zParent.ContentsResized, AddressOf zParent_ContentsResized
                    RemoveHandler withEventsField_zParent.Disposed, AddressOf zParent_Disposed
                End If
                withEventsField_zParent = value
                If withEventsField_zParent IsNot Nothing Then
                    AddHandler withEventsField_zParent.LocationChanged, AddressOf zParent_Changed
                    AddHandler withEventsField_zParent.Move, AddressOf zParent_Changed
                    AddHandler withEventsField_zParent.Resize, AddressOf zParent_Changed
                    AddHandler withEventsField_zParent.DockChanged, AddressOf zParent_Changed
                    AddHandler withEventsField_zParent.TextChanged, AddressOf zParent_Changed
                    AddHandler withEventsField_zParent.MultilineChanged, AddressOf zParent_Changed
                    AddHandler withEventsField_zParent.HScroll, AddressOf zParent_Scroll
                    AddHandler withEventsField_zParent.VScroll, AddressOf zParent_Scroll
                    AddHandler withEventsField_zParent.ContentsResized, AddressOf zParent_ContentsResized
                    AddHandler withEventsField_zParent.Disposed, AddressOf zParent_Disposed
                End If
            End Set
        End Property

        'private Windows.Forms.Timer withEventsField_zTimer = new Windows.Forms.Timer();
        'private Windows.Forms.Timer zTimer {
        'private Timer withEventsField_zTimer = new Windows.Forms.Timer();
        Private withEventsField_zTimer As New Timer()
        Private ReadOnly Property zTimer() As Timer
            Get
                Return withEventsField_zTimer
            End Get
        End Property

        Private zAutoSizing As Boolean = True
        Private zAutoSizing_Size As New Size(0, 0)
        'private Rectangle zContentRectangle = null;
        Private zContentRectangle As Rectangle
        Private zDockSide As LineNumberDockside = LineNumberDockside.Left
        Private zParentIsScrolling As Boolean = False

        Private zSeeThroughMode As Boolean = False
        Private zGradient_Show As Boolean = True
        Private zGradient_Direction As System.Drawing.Drawing2D.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Private zGradient_StartColor As Color = Color.FromArgb(0, 0, 0, 0)

        Private zGradient_EndColor As Color = Color.LightSteelBlue
        Private zGridLines_Show As Boolean = True
        Private zGridLines_Thickness As Single = 1
        Private zGridLines_Style As System.Drawing.Drawing2D.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot

        Private zGridLines_Color As Color = Color.SlateGray
        Private zBorderLines_Show As Boolean = True
        Private zBorderLines_Thickness As Single = 1
        Private zBorderLines_Style As System.Drawing.Drawing2D.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot

        Private zBorderLines_Color As Color = Color.SlateGray
        Private zMarginLines_Show As Boolean = True
        Private zMarginLines_Side As LineNumberDockside = LineNumberDockside.Right
        Private zMarginLines_Thickness As Single = 1
        Private zMarginLines_Style As System.Drawing.Drawing2D.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid

        Private zMarginLines_Color As Color = Color.SlateGray
        Private zLineNumbers_Show As Boolean = True
        Private zLineNumbers_ShowLeadingZeroes As Boolean = True
        Private zLineNumbers_ShowAsHexadecimal As Boolean = False
        Private zLineNumbers_ClipByItemRectangle As Boolean = True
        Private zLineNumbers_Offset As New Size(0, 0)
        Private zLineNumbers_Format As String = "0"
        Private zLineNumbers_Alignment As System.Drawing.ContentAlignment = ContentAlignment.TopRight

        Private zLineNumbers_AntiAlias As Boolean = True

        Private zLNIs As New List(Of LineNumberItem)()
        Private zPointInParent As New Point(0, 0)
        Private zPointInMe As New Point(0, 0)
        Private zParentInMe As Integer = 0
        '''/////////////////////////////////////////////////////////////////////////////////////////////////

        Public Sub New()
            Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            Me.SetStyle(ControlStyles.ResizeRedraw, True)
            Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
            Me.SetStyle(ControlStyles.UserPaint, True)
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            Me.Margin = New Padding(0)
            Me.Padding = New Padding(0, 0, 2, 0)
            zTimer.Enabled = True
            zTimer.Interval = 1000
            zTimer.[Stop]()
            Me.Update_SizeAndPosition()
            Me.Invalidate()
        End Sub

        Protected Overloads Overrides Sub OnHandleCreated(ByVal e As System.EventArgs)
            On Error Resume Next
            MyBase.OnHandleCreated(e)
            Me.AutoSize = False
        End Sub
#Region "       PUBLIC PROPERTIES "
        <System.ComponentModel.Browsable(False)> _
        Public Overloads Overrides Property AutoSize() As Boolean
            Get
                Return MyBase.AutoSize
            End Get
            Set(value As Boolean)
                MyBase.AutoSize = value
                Me.Invalidate()
            End Set
        End Property
        <System.ComponentModel.Description("Use this property to enable LineNumbers for the chosen RichTextBox.")> _
        <System.ComponentModel.Category("Add LineNumbers to")> _
        Public WriteOnly Property ParentRichTextBox() As RichTextBox
            Set(value As RichTextBox)
                zParent = value
                If zParent IsNot Nothing Then
                    Me.Parent = zParent.Parent
                    zParent.Refresh()
                End If
                Me.Text = ""
                Me.Refresh()
                Me.Invalidate()
            End Set
        End Property
        <System.ComponentModel.Description("BorderLines are shown on all sides of the LineNumber control.")> _
        <System.ComponentModel.Category("Additional Behavior")> _
        Public WriteOnly Property Show_BorderLines() As Boolean
            Set(value As Boolean)
                zBorderLines_Show = value
                Me.Invalidate()
            End Set
        End Property
        <System.ComponentModel.Category("Additional Appearance")> _
        Public WriteOnly Property BorderLines_Thickness() As Single
            Set(value As Single)
                zBorderLines_Thickness = Math.Max(1, Math.Min(255, value))
                Me.Invalidate()
            End Set
        End Property
        <System.ComponentModel.Category("Additional Appearance")> _
        Public WriteOnly Property BorderLines_Style() As System.Drawing.Drawing2D.DashStyle
            Set(value As System.Drawing.Drawing2D.DashStyle)
                If value = System.Drawing.Drawing2D.DashStyle.[Custom] Then
                    value = System.Drawing.Drawing2D.DashStyle.Solid
                End If
                zBorderLines_Style = value
                Me.Invalidate()
            End Set
        End Property
        <System.ComponentModel.Description("GridLines are the horizontal divider-lines shown above each LineNumber.")> _
        <System.ComponentModel.Category("Additional Behavior")> _
        Public WriteOnly Property Show_GridLines() As Boolean
            Set(value As Boolean)
                zGridLines_Show = value
                Me.Invalidate()
            End Set
        End Property
        <System.ComponentModel.Category("Additional Appearance")> _
        Public WriteOnly Property GridLines_Color() As Color
            Set(value As Color)
                zGridLines_Color = value
                Me.Invalidate()
            End Set
        End Property
        <System.ComponentModel.Category("Additional Appearance")> _
        Public WriteOnly Property GridLines_Thickness() As Single
            Set(value As Single)
                zGridLines_Thickness = Math.Max(1, Math.Min(255, value))
                Me.Invalidate()
            End Set
        End Property
        <System.ComponentModel.Description("MarginLines are shown on the Left or Right (or both in Height-mode) of the LineNumber control.")> _
        <System.ComponentModel.Category("Additional Behavior")> _
        Public WriteOnly Property Show_MarginLines() As Boolean
            Set(value As Boolean)
                zMarginLines_Show = value
                Me.Invalidate()
            End Set
        End Property
        <System.ComponentModel.Category("Additional Appearance")> _
        Public WriteOnly Property MarginLines_Side() As LineNumberDockside
            Set(value As LineNumberDockside)
                zMarginLines_Side = value
                Me.Invalidate()
            End Set
        End Property
        <System.ComponentModel.Category("Additional Appearance")> _
        Public WriteOnly Property MarginLines_Color() As Color
            Set(value As Color)
                zMarginLines_Color = value
                Me.Invalidate()
            End Set
        End Property
        <System.ComponentModel.Category("Additional Appearance")> _
        Public WriteOnly Property MarginLines_Thickness() As Single
            Set(value As Single)
                zMarginLines_Thickness = Math.Max(1, Math.Min(255, value))
                Me.Invalidate()
            End Set
        End Property
        <System.ComponentModel.Category("Additional Appearance")> _
        Public WriteOnly Property MarginLines_Style() As System.Drawing.Drawing2D.DashStyle
            Set(value As System.Drawing.Drawing2D.DashStyle)
                If value = System.Drawing.Drawing2D.DashStyle.[Custom] Then
                    value = System.Drawing.Drawing2D.DashStyle.Solid
                End If
                zMarginLines_Style = value
                Me.Invalidate()
            End Set
        End Property
        <System.ComponentModel.Description("The BackgroundGradient is a gradual blend of two colors, shown in the back of each LineNumber's item-area.")> _
        <System.ComponentModel.Category("Additional Behavior")> _
        Public WriteOnly Property Show_BackgroundGradient() As Boolean
            Set(value As Boolean)
                zGradient_Show = value
                Me.Invalidate()
            End Set
        End Property
        <System.ComponentModel.Category("Additional Appearance")> _
        Public ReadOnly Property BackgroundGradient_BetaColor() As Color
            Get
                Return zGradient_EndColor
            End Get
        End Property
        <System.ComponentModel.Description("Use this to set whether the LineNumbers should have leading zeroes (based on the total amount of textlines).")> _
        <System.ComponentModel.Category("Additional Behavior")> _
        Public WriteOnly Property LineNrs_LeadingZeroes() As Boolean
            Set(value As Boolean)
                zLineNumbers_ShowLeadingZeroes = value
                Me.Refresh()
                Me.Invalidate()
            End Set
        End Property
        <System.ComponentModel.Description("Use this to apply Anti-Aliasing to the LineNumbers (high quality). Some fonts will look better without it, though.")> _
        <System.ComponentModel.Category("Additional Behavior")> _
        Public WriteOnly Property LineNrs_AntiAlias() As Boolean
            Set(value As Boolean)
                zLineNumbers_AntiAlias = value
                Me.Refresh()
                Me.Invalidate()
            End Set
        End Property
        <System.ComponentModel.Browsable(True)> _
        Public Overloads Overrides Property Font() As System.Drawing.Font
            Get
                Return MyBase.Font
            End Get
            Set(value As System.Drawing.Font)
                MyBase.Font = value
                Me.Refresh()
                Me.Invalidate()
            End Set
        End Property
        <System.ComponentModel.DefaultValue("")> _
        <System.ComponentModel.AmbientValue("")> _
        <System.ComponentModel.Browsable(False)> _
        Public Overloads Overrides Property Text() As String
            Get
                Return MyBase.Text
            End Get
            Set(value As String)
                MyBase.Text = ""
                Me.Invalidate()
            End Set
        End Property
#End Region
        Protected Overloads Overrides Sub OnSizeChanged(ByVal e As System.EventArgs)
            If Me.DesignMode = True Then
                Me.Refresh()
            End If
            MyBase.OnSizeChanged(e)
            Me.Invalidate()
        End Sub

        Protected Overloads Overrides Sub OnLocationChanged(ByVal e As System.EventArgs)
            If Me.DesignMode = True Then
                Me.Refresh()
            End If
            MyBase.OnLocationChanged(e)
            Me.Invalidate()
        End Sub

        Public Overloads Overrides Sub Refresh()
            '   Note: don't change the order here, first the Mybase.Refresh, then the Update_SizeAndPosition.
            MyBase.Refresh()
            Me.Update_SizeAndPosition()
        End Sub

        ''' <summary>
        ''' This Sub will run whenever Me.Refresh() is called. It applies the AutoSizing and DockSide settings.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub Update_SizeAndPosition()
            If Me.AutoSize = True Then
                Return
            End If
            If Me.Dock = DockStyle.Bottom Or Me.Dock = DockStyle.Fill Or Me.Dock = DockStyle.Top Then
                Return
            End If
            Dim zNewLocation As Point = Me.Location
            Dim zNewSize As Size = Me.Size

            If zAutoSizing = True Then
                'switch (true) {
                '	case zParent == null:
                If zParent Is Nothing Then
                    ' --- ReminderMessage sizing
                    If zAutoSizing_Size.Width > 0 Then
                        zNewSize.Width = zAutoSizing_Size.Width
                    End If
                    If zAutoSizing_Size.Height > 0 Then
                        zNewSize.Height = zAutoSizing_Size.Height
                    End If

                    ' break;
                    Me.Size = zNewSize
                ElseIf Me.Dock = DockStyle.Left Or Me.Dock = DockStyle.Right Then
                    '--- zParent isNot Nothing for the following cases
                    'case this.Dock == DockStyle.Left | this.Dock == DockStyle.Right:
                    If zAutoSizing_Size.Width > 0 Then
                        zNewSize.Width = zAutoSizing_Size.Width
                    End If

                    'break;
                    Me.Width = zNewSize.Width
                ElseIf zDockSide <> LineNumberDockside.None Then
                    ' --- DockSide is active L/R/H
                    'case zDockSide != LineNumberDockSide.None:
                    If zAutoSizing_Size.Width > 0 Then
                        zNewSize.Width = zAutoSizing_Size.Width
                    End If
                    zNewSize.Height = zParent.Height
                    If zDockSide = LineNumberDockside.Left Then
                        zNewLocation.X = zParent.Left - zNewSize.Width - 1
                    End If
                    If zDockSide = LineNumberDockside.Right Then
                        zNewLocation.X = zParent.Right + 1
                    End If
                    zNewLocation.Y = zParent.Top
                    Me.Location = zNewLocation

                    'break;
                    Me.Size = zNewSize
                ElseIf zDockSide = LineNumberDockside.None Then
                    ' --- DockSide = None, but AutoSizing is still setting the Width
                    'case zDockSide == LineNumberDockSide.None:
                    If zAutoSizing_Size.Width > 0 Then
                        zNewSize.Width = zAutoSizing_Size.Width
                    End If

                    'break;
                    Me.Size = zNewSize

                End If
            Else
                ' --- No AutoSizing
                'switch (true) {
                If zParent Is Nothing Then
                    'case zParent == null:
                    ' --- ReminderMessage sizing
                    If zAutoSizing_Size.Width > 0 Then
                        zNewSize.Width = zAutoSizing_Size.Width
                    End If
                    If zAutoSizing_Size.Height > 0 Then
                        zNewSize.Height = zAutoSizing_Size.Height
                    End If

                    'break;
                    Me.Size = zNewSize
                ElseIf zDockSide <> LineNumberDockside.None Then
                    ' --- No AutoSizing, but DockSide L/R/H is active so height and position need updates.
                    'case zDockSide != LineNumberDockSide.None:
                    zNewSize.Height = zParent.Height
                    If zDockSide = LineNumberDockside.Left Then
                        zNewLocation.X = zParent.Left - zNewSize.Width - 1
                    End If
                    If zDockSide = LineNumberDockside.Right Then
                        zNewLocation.X = zParent.Right + 1
                    End If
                    zNewLocation.Y = zParent.Top
                    Me.Location = zNewLocation

                    'break;
                    Me.Size = zNewSize
                End If
            End If

        End Sub


        ''' <summary>
        ''' This Sub determines which textlines are visible in the ParentRichTextBox, and makes LineNumberItems (LineNumber + ItemRectangle)
        ''' for each visible line. They are put into the zLNIs List that will be used by the OnPaint event to draw the LineNumberItems. 
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub Update_VisibleLineNumberItems()

            ' ################
            Dim tmpY As Integer
            ' ###############
            zLNIs.Clear()
            zAutoSizing_Size = New Size(0, 0)
            zLineNumbers_Format = "0"
            'initial setting
            '   To measure the LineNumber's width, its Format 0 is replaced by w as that is likely to be one of the widest characters in non-monospace fonts. 
            If zAutoSizing = True Then
                zAutoSizing_Size = New Size(TextRenderer.MeasureText(zLineNumbers_Format.Replace("0"c, "W"c), Me.Font).Width, 0)
            End If
            'zAutoSizing_Size = new Size(TextRenderer.MeasureText(zLineNumbers_Format.Replace("0".ToCharArray(), "W".ToCharArray()), this.Font).Width, 0);

            If zParent Is Nothing OrElse String.IsNullOrEmpty(zParent.Text) Then
                Return
            End If

            ' --- Make sure the LineNumbers are aligning to the same height as the zParent textlines by converting to screencoordinates
            '   and using that as an offset that gets added to the points for the LineNumberItems
            zPointInParent = zParent.PointToScreen(zParent.ClientRectangle.Location)
            zPointInMe = Me.PointToScreen(New Point(0, 0))
            '   zParentInMe is the vertical offset to make the LineNumberItems line up with the textlines in zParent.
            zParentInMe = zPointInParent.Y - zPointInMe.Y + 1
            '   The first visible LineNumber may not be the first visible line of text in the RTB if the LineNumbercontrol's .Top is lower on the form than
            '   the .Top of the parent RichTextBox. Therefor, zPointInParent will now be used to find zPointInMe's equivalent height in zParent, 
            '   which is needed to find the best StartIndex later on.
            zPointInParent = zParent.PointToClient(zPointInMe)

            ' --- NOTES: 
            '   Additional complication is the fact that when wordwrap is enabled on the RTB, the wordwrapped text spills into the RTB.Lines collection, 
            '   so we need to split the text into lines ourselves, and use the Index of each zSplit-line's first character instead of the RTB's.
            Dim zSplit As String() = zParent.Text.Split(Environment.NewLine.ToCharArray())

            If zSplit.Length < 2 Then
                '   Just one line in the text = one linenumber
                '   NOTE:  zContentRectangle is built by the zParent.ContentsResized event.
                Dim zPoint As Point = zParent.GetPositionFromCharIndex(0)


                zLNIs.Add(New LineNumberItem(1, New Rectangle(New Point(0, zPoint.Y - 1 + zParentInMe), New Size(Me.Width, zContentRectangle.Height - zPoint.Y))))
            Else
                '   Multiple lines, but store only those LineNumberItems for lines that are visible.
                Dim zTimeSpan As New TimeSpan(DateAndTime.Now.Ticks)
                Dim zPoint As New Point(0, 0)
                Dim zStartIndex As Integer = 0
                Dim zSplitStartLine As Integer = 0
                Dim zA As Integer = zParent.Text.Length - 1
                ' #########################

                'this.FindStartIndex(ref zStartIndex, ref zA, ref zPointInParent.Y);
                tmpY = zPointInParent.Y
                Me.FindStartIndex(zStartIndex, zA, tmpY)
                zPointInParent.Y = tmpY

                ' ################


                '   zStartIndex now holds the index of a character in the first visible line from zParent.Text
                '   Now it will be pointed at the first character of that line (chr(10) = Linefeed part of the Environment.NewLine constant)
                zStartIndex = Math.Max(0, Math.Min(zParent.Text.Length - 1, zParent.Text.Substring(0, zStartIndex).LastIndexOf(Strings.Chr(10)) + 1))

                '   We now need to find out which zSplit-line that character is in, by counting the vbCrlf appearances that come before it.
                zSplitStartLine = Math.Max(0, zParent.Text.Substring(0, zStartIndex).Split(Environment.NewLine.ToCharArray()).Length - 1)
                For zA = zSplitStartLine To zSplit.Length - 1

                    '   zStartIndex starts off pointing at the first character of the first visible line, and will be then be pointed to 
                    '   the index of the first character on the next line.
                    zPoint = zParent.GetPositionFromCharIndex(zStartIndex)
                    zStartIndex += Math.Max(1, zSplit(zA).Length + 1)
                    If zPoint.Y + zParentInMe > Me.Height Then
                        Exit For
                    End If
                    ' TODO: might not be correct. Was : Exit For
                    '   For performance reasons, the list of LineNumberItems (zLNIs) is first built with only the location of its 
                    '   itemrectangle being used. The height of those rectangles will be computed afterwards by comparing the items' Y coordinates.
                    zLNIs.Add(New LineNumberItem(zA + 1, New Rectangle(0, zPoint.Y - 1 + zParentInMe, Me.Width, 1)))
                    If zParentIsScrolling = True AndAlso DateAndTime.Now.Ticks > zTimeSpan.Ticks + 500000 Then
                        '   The more lines there are in the RTB, the slower the RTB's .GetPositionFromCharIndex() method becomes
                        '   To avoid those delays from interfering with the scrollingspeed, this speedbased exit for is applied (0.05 sec)
                        '   zLNIs will have at least 1 item, and if that's the only one, then change its location to 0,0 to make it readable
                        If zLNIs.Count = 1 Then
                            zLNIs(0).Rectangle.Y = 0
                        End If
                        ' zLNIs(0).Rectangle.Y = 0;

                        zParentIsScrolling = False
                        zTimer.Start()
                        ' TODO: might not be correct. Was : Exit For
                        Exit For
                    End If
                Next

                If zLNIs.Count = 0 Then
                    Return
                End If

                '   Add an extra placeholder item to the end, to make the heightcomputation easier
                If zA < zSplit.Length Then
                    '   getting here means the for/next loop was exited before reaching the last zSplit textline
                    '   zStartIndex will still be pointing to the startcharacter of the next line, so we can use that:
                    zPoint = zParent.GetPositionFromCharIndex(Math.Min(zStartIndex, zParent.Text.Length - 1))
                    zLNIs.Add(New LineNumberItem(-1, New Rectangle(0, zPoint.Y - 1 + zParentInMe, 0, 0)))
                Else
                    '   getting here means the for/next loop ran to the end (zA is now zSplit.Length). 
                    zLNIs.Add(New LineNumberItem(-1, New Rectangle(0, zContentRectangle.Bottom, 0, 0)))
                End If
                For zA = 0 To zLNIs.Count - 2

                    '   And now we can easily compute the height of the LineNumberItems by comparing each item's Y coordinate with that of the next line.
                    '   There's at least two items in the list, and the last item is a "nextline-placeholder" that will be removed.
                    'zLNIs(zA).Rectangle.Height = Math.Max(1, zLNIs(zA + 1).Rectangle.Y - zLNIs(zA).Rectangle.Y);
                    zLNIs(zA).Rectangle.Height = Math.Max(1, zLNIs(zA + 1).Rectangle.Y - zLNIs(zA).Rectangle.Y)
                Next
                '   Removing the placeholder item
                zLNIs.RemoveAt(zLNIs.Count - 1)

                ' Set the Format to the width of the highest possible number so that LeadingZeroes shows the correct amount of zeroes.
                If zLineNumbers_ShowAsHexadecimal = True Then
                    zLineNumbers_Format = "".PadRight(zSplit.Length.ToString("X").Length, "0"c)
                Else
                    zLineNumbers_Format = "".PadRight(zSplit.Length.ToString.Length, "0"c)
                End If
            End If

            '   To measure the LineNumber's width, its Format 0 is replaced by w as that is likely to be one of the widest characters in non-monospace fonts. 
            If zAutoSizing = True Then
                zAutoSizing_Size = New Size(TextRenderer.MeasureText(zLineNumbers_Format.Replace("0"c, "W"c), Me.Font).Width, 0)
            End If
            'zAutoSizing_Size = new Size(TextRenderer.MeasureText(zLineNumbers_Format.Replace("0".ToCharArray(), "W".ToCharArray()), this.Font).Width, 0);
        End Sub

        ''' <summary>
        ''' FindStartIndex is a recursive Sub (one that calls itself) to compute the first visible line that should have a LineNumber.
        ''' </summary>
        ''' <param name="zMin"> this will hold the eventual BestStartIndex when the Sub has completed its run.</param>
        ''' <param name="zMax"></param>
        ''' <param name="zTarget"></param>
        ''' <remarks></remarks>
        Private Sub FindStartIndex(ByRef zMin As Integer, ByRef zMax As Integer, ByRef zTarget As Integer)
            '   Recursive Sub to compute best starting index - only run when zParent is known to exist
            If zMax = zMin + 1 Or zMin = (zMax + zMin) / 2 Then
                Return
            End If

            If zParent.GetPositionFromCharIndex(CInt((zMax + zMin) / 2)).Y = zTarget Then
                'switch (zParent.GetPositionFromCharIndex((zMax + zMin) / 2).Y) {
                '	case  // ERROR: Case labels with binary operators are unsupported : Equality
                '   BestStartIndex found
                'break;
                zMin = CInt((zMax + zMin) / 2)
            ElseIf zParent.GetPositionFromCharIndex(CInt((zMax + zMin) / 2)).Y > zTarget Then
                'case  // ERROR: Case labels with binary operators are unsupported : GreaterThan
                'zTarget:
                '   Look again, in lower half
                zMax = CInt((zMax + zMin) / 2)
                'break;
                FindStartIndex(zMin, zMax, zTarget)
            ElseIf zParent.GetPositionFromCharIndex(CInt((zMax + zMin) / 2)).Y < 0 Then
                ' case  // ERROR: Case labels with binary operators are unsupported : LessThan
                '0:
                '   Look again, in top half
                zMin = CInt((zMax + zMin) / 2)
                'break;
                FindStartIndex(zMin, zMax, zTarget)
            End If

        End Sub


        ''' <summary>
        ''' OnPaint will go through the enabled elements (vertical ReminderMessage, GridLines, LineNumbers, BorderLines, MarginLines) and will
        ''' draw them if enabled. At the same time, it will build GraphicsPaths for each of those elements (that are enabled), which will be used 
        ''' in SeeThroughMode (if it's active): the figures in the GraphicsPaths will form a customized outline for the control by setting them as the 
        ''' Region of the LineNumber control. Note: the vertical ReminderMessages are only drawn during designtime. 
        ''' </summary>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Protected Overloads Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
            '   Build the list of visible LineNumberItems (= zLNIs) first. (doesn't take long, so it can stay in OnPaint)
            If e Is Nothing Then Return
            Me.Update_VisibleLineNumberItems()
            MyBase.OnPaint(e)

            ' --- QualitySettings
            If zLineNumbers_AntiAlias = True Then
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
            Else
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            End If

            ' --- Local Declarations
            Dim zTextToShow As String = ""
            Dim zReminderToShow As String = ""
            Dim zSF As New StringFormat()
            Dim zTextSize As SizeF = Nothing
            Dim zPen As New Pen(Me.ForeColor)
            Dim zBrush As New SolidBrush(Me.ForeColor)
            Dim zPoint As New Point(0, 0)
            Dim zItemClipRectangle As New Rectangle(0, 0, 0, 0)

            '   NOTE: The GraphicsPaths are only used for SeeThroughMode
            '   FillMode.Winding: combined outline ( Alternate: XOR'ed outline )
            Dim zGP_GridLines As New System.Drawing.Drawing2D.GraphicsPath(System.Drawing.Drawing2D.FillMode.Winding)
            Dim zGP_BorderLines As New System.Drawing.Drawing2D.GraphicsPath(System.Drawing.Drawing2D.FillMode.Winding)
            Dim zGP_MarginLines As New System.Drawing.Drawing2D.GraphicsPath(System.Drawing.Drawing2D.FillMode.Winding)
            Dim zGP_LineNumbers As New System.Drawing.Drawing2D.GraphicsPath(System.Drawing.Drawing2D.FillMode.Winding)
            Dim zRegion As New Region(MyBase.ClientRectangle)


            ' ----------------------------------------------
            ' --- DESIGNTIME / NO VISIBLE ITEMS
            If Me.DesignMode = True Then
                '   Show a vertical reminder message
                If zParent Is Nothing Then
                    zReminderToShow = "-!- Set ParentRichTextBox -!-"
                Else
                    If zLNIs.Count = 0 Then
                        zReminderToShow = "LineNrs (  " + zParent.Name + "  )"
                    End If
                End If
                If zReminderToShow.Length > 0 Then
                    ' --- Centering and Rotation for the reminder message
                    e.Graphics.TranslateTransform(CSng(Me.Width / 2), CSng(Me.Height / 2))
                    e.Graphics.RotateTransform(-90)
                    zSF.Alignment = StringAlignment.Center
                    zSF.LineAlignment = StringAlignment.Center
                    ' --- Show the reminder message (with small shadow)
                    zTextSize = e.Graphics.MeasureString(zReminderToShow, Me.Font, zPoint, zSF)
                    e.Graphics.DrawString(zReminderToShow, Me.Font, Brushes.WhiteSmoke, 1, 1, zSF)
                    e.Graphics.DrawString(zReminderToShow, Me.Font, Brushes.Firebrick, 0, 0, zSF)
                    e.Graphics.ResetTransform()

                    'Rectangle zReminderRectangle = new Rectangle(this.Width / 2 - zTextSize.Height / 2, this.Height / 2 - zTextSize.Width / 2, zTextSize.Height, zTextSize.Width);
                    Dim zReminderRectangle As New Rectangle(CInt((Me.Width / 2 - zTextSize.Height / 2)), CInt((Me.Height / 2 - zTextSize.Width / 2)), CInt((zTextSize.Height)), CInt((zTextSize.Width)))
                    zGP_LineNumbers.AddRectangle(zReminderRectangle)
                    zGP_LineNumbers.CloseFigure()

                    If zAutoSizing = True Then
                        zReminderRectangle.Inflate(CInt((zTextSize.Height * 0.2)), CInt((zTextSize.Width * 0.1)))
                        'zReminderRectangle.Inflate(zTextSize.Height * 0.2, zTextSize.Width * 0.1);
                        zAutoSizing_Size = New Size(zReminderRectangle.Width, zReminderRectangle.Height)
                    End If
                End If
            End If


            ' ----------------------------------------------
            ' --- DESIGN OR RUNTIME / WITH VISIBLE ITEMS (which means zParent exists)
            If zLNIs.Count > 0 Then
                '   The visible LineNumberItems with their BackgroundGradient and GridLines
                '   Loop through every visible LineNumberItem
                Dim zLGB As System.Drawing.Drawing2D.LinearGradientBrush = Nothing
                zPen = New Pen(zGridLines_Color, zGridLines_Thickness)
                zPen.DashStyle = zGridLines_Style
                zSF.Alignment = StringAlignment.Near
                zSF.LineAlignment = StringAlignment.Near
                'zSF.FormatFlags = StringFormatFlags.FitBlackBox + StringFormatFlags.NoClip + StringFormatFlags.NoWrap;
                zSF.FormatFlags = StringFormatFlags.FitBlackBox Or StringFormatFlags.NoClip Or StringFormatFlags.NoWrap
                For zA As Integer = 0 To zLNIs.Count - 1


                    ' --- BackgroundGradient
                    If zGradient_Show = True Then
                        'zLGB = new Drawing2D.LinearGradientBrush(zLNIs(zA).Rectangle, zGradient_StartColor, zGradient_EndColor, zGradient_Direction);
                        zLGB = New System.Drawing.Drawing2D.LinearGradientBrush(zLNIs(zA).Rectangle, zGradient_StartColor, zGradient_EndColor, zGradient_Direction)
                        'e.Graphics.FillRectangle(zLGB, zLNIs(zA).Rectangle);
                        e.Graphics.FillRectangle(zLGB, zLNIs(zA).Rectangle)
                    End If

                    ' --- GridLines
                    If zGridLines_Show = True Then
                        e.Graphics.DrawLine(zPen, New Point(0, zLNIs(zA).Rectangle.Y), New Point(Me.Width, zLNIs(zA).Rectangle.Y))
                        'e.Graphics.DrawLine(zPen, new Point(0, zLNIs(zA).Rectangle.Y), new Point(this.Width, zLNIs(zA).Rectangle.Y));

                        '   NOTE: Every item in a GraphicsPath is a closed figure, so instead of adding gridlines as lines, we'll add them
                        '   as rectangles that loop out of sight. Their height uses the zContentRectangle which is the maxsize of 
                        '   the ParentRichTextBox's contents. 
                        '   NOTE: Slight adjustment needed when the first item has a negative Y coordinate. 
                        '   This explains the " - zLNIs(0).Rectangle.Y" (which adds the negative size to the height 
                        '   to make sure the rectangle's bottompart stays out of sight) 
                        'zGP_GridLines.AddRectangle(new Rectangle(-zGridLines_Thickness, zLNIs(zA).Rectangle.Y, this.Width + zGridLines_Thickness * 2, this.Height - zLNIs(0).Rectangle.Y + zGridLines_Thickness));
                        zGP_GridLines.AddRectangle(New Rectangle(CInt((-zGridLines_Thickness)), CInt((zLNIs(zA).Rectangle.Y)), CInt((Me.Width + zGridLines_Thickness * 2)), CInt((Me.Height - zLNIs(zA).Rectangle.Y + zGridLines_Thickness))))
                        zGP_GridLines.CloseFigure()
                    End If

                    ' --- LineNumbers
                    If zLineNumbers_Show = True Then
                        '   TextFormatting
                        If zLineNumbers_ShowLeadingZeroes = True Then
                            'zTextToShow = (zLineNumbers_ShowAsHexadecimal ? zLNIs(zA).LineNumber.ToString("X") : zLNIs(zA).LineNumber.ToString(zLineNumbers_Format));
                            zTextToShow = CStr((IIf(zLineNumbers_ShowAsHexadecimal, zLNIs(zA).LineNumber.ToString("X"), zLNIs(zA).LineNumber.ToString(zLineNumbers_Format))))
                        Else
                            'zTextToShow = (zLineNumbers_ShowAsHexadecimal ? zLNIs(zA).LineNumber.ToString("X") : zLNIs(zA).LineNumber.ToString);
                            zTextToShow = CStr((IIf(zLineNumbers_ShowAsHexadecimal, zLNIs(zA).LineNumber.ToString("X"), zLNIs(zA).LineNumber.ToString())))
                        End If

                        '   TextSizing
                        zTextSize = e.Graphics.MeasureString(zTextToShow, Me.Font, zPoint, zSF)
                        '   TextAlignment and positioning   (zPoint = TopLeftCornerPoint of the text)
                        '   TextAlignment, padding, manual offset (via LineNrs_Offset) and zTextSize are all included in the calculation of zPoint. 
                        Select Case zLineNumbers_Alignment
                            Case ContentAlignment.TopLeft
                                zPoint = New Point(CInt((zLNIs(zA).Rectangle.Left + Me.Padding.Left + zLineNumbers_Offset.Width)), CInt((zLNIs(zA).Rectangle.Top + Me.Padding.Top + zLineNumbers_Offset.Height)))
                                Exit Select
                            Case ContentAlignment.MiddleLeft
                                zPoint = New Point(CInt((zLNIs(zA).Rectangle.Left + Me.Padding.Left + zLineNumbers_Offset.Width)), CInt((zLNIs(zA).Rectangle.Top + (zLNIs(zA).Rectangle.Height / 2) + zLineNumbers_Offset.Height - zTextSize.Height / 2)))
                                Exit Select
                            Case ContentAlignment.BottomLeft
                                zPoint = New Point(CInt((zLNIs(zA).Rectangle.Left + Me.Padding.Left + zLineNumbers_Offset.Width)), CInt((zLNIs(zA).Rectangle.Bottom - Me.Padding.Bottom + 1 + zLineNumbers_Offset.Height - zTextSize.Height)))
                                Exit Select
                            Case ContentAlignment.TopCenter
                                zPoint = New Point(CInt((zLNIs(zA).Rectangle.Width / 2 + zLineNumbers_Offset.Width - zTextSize.Width / 2)), CInt((zLNIs(zA).Rectangle.Top + Me.Padding.Top + zLineNumbers_Offset.Height)))
                                Exit Select
                            Case ContentAlignment.MiddleCenter
                                zPoint = New Point(CInt((zLNIs(zA).Rectangle.Width / 2 + zLineNumbers_Offset.Width - zTextSize.Width / 2)), CInt((zLNIs(zA).Rectangle.Top + (zLNIs(zA).Rectangle.Height / 2) + zLineNumbers_Offset.Height - zTextSize.Height / 2)))
                                Exit Select
                            Case ContentAlignment.BottomCenter
                                zPoint = New Point(CInt((zLNIs(zA).Rectangle.Width / 2 + zLineNumbers_Offset.Width - zTextSize.Width / 2)), CInt((zLNIs(zA).Rectangle.Bottom - Me.Padding.Bottom + 1 + zLineNumbers_Offset.Height - zTextSize.Height)))
                                Exit Select
                            Case ContentAlignment.TopRight
                                zPoint = New Point(CInt((zLNIs(zA).Rectangle.Right - Me.Padding.Right + zLineNumbers_Offset.Width - zTextSize.Width)), CInt((zLNIs(zA).Rectangle.Top + Me.Padding.Top + zLineNumbers_Offset.Height)))
                                Exit Select
                            Case ContentAlignment.MiddleRight
                                zPoint = New Point(CInt((zLNIs(zA).Rectangle.Right - Me.Padding.Right + zLineNumbers_Offset.Width - zTextSize.Width)), CInt((zLNIs(zA).Rectangle.Top + (zLNIs(zA).Rectangle.Height / 2) + zLineNumbers_Offset.Height - zTextSize.Height / 2)))
                                Exit Select
                            Case ContentAlignment.BottomRight
                                zPoint = New Point(CInt((zLNIs(zA).Rectangle.Right - Me.Padding.Right + zLineNumbers_Offset.Width - zTextSize.Width)), CInt((zLNIs(zA).Rectangle.Bottom - Me.Padding.Bottom + 1 + zLineNumbers_Offset.Height - zTextSize.Height)))
                                Exit Select
                        End Select
                        '   TextClipping
                        zItemClipRectangle = New Rectangle(zPoint, zTextSize.ToSize())
                        If zLineNumbers_ClipByItemRectangle = True Then
                            '   If selected, the text will be clipped so that it doesn't spill out of its own LineNumberItem-area.
                            '   Only the part of the text inside the LineNumberItem.Rectangle should be visible, so intersect with the ItemRectangle
                            '   The SetClip method temporary restricts the drawing area of the control for whatever is drawn next.
                            zItemClipRectangle.Intersect(zLNIs(zA).Rectangle)
                            e.Graphics.SetClip(zItemClipRectangle)
                        End If
                        '   TextDrawing
                        e.Graphics.DrawString(zTextToShow, Me.Font, zBrush, zPoint, zSF)
                        e.Graphics.ResetClip()
                        '   The GraphicsPath for the LineNumber is just a rectangle behind the text, to keep the paintingspeed high and avoid ugly artifacts.
                        zGP_LineNumbers.AddRectangle(zItemClipRectangle)
                        zGP_LineNumbers.CloseFigure()
                    End If
                Next

                ' --- GridLinesThickness and Linestyle in SeeThroughMode. All GraphicsPath lines are drawn as solid to keep the paintingspeed high.
                If zGridLines_Show = True Then
                    zPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
                    zGP_GridLines.Widen(zPen)
                End If

                ' --- Memory CleanUp
                If zLGB IsNot Nothing Then
                    zLGB.Dispose()
                End If
            End If


            ' ----------------------------------------------
            ' --- DESIGN OR RUNTIME / ALWAYS
            'Point zP_Left = new Point(Math.Floor(zBorderLines_Thickness / 2), Math.Floor(zBorderLines_Thickness / 2));
            'Point zP_Right = new Point(this.Width - Math.Ceiling(zBorderLines_Thickness / 2), this.Height - Math.Ceiling(zBorderLines_Thickness / 2));

            Dim zP_Left As New Point(CInt((Math.Floor(zBorderLines_Thickness / 2))), CInt((Math.Floor(zBorderLines_Thickness / 2))))
            Dim zP_Right As New Point(CInt((Me.Width - Math.Ceiling(zBorderLines_Thickness / 2))), CInt((Me.Height - Math.Ceiling(zBorderLines_Thickness / 2))))

            ' --- BorderLines 
            Dim zBorderLines_Points As Point() = {New Point(zP_Left.X, zP_Left.Y), New Point(zP_Right.X, zP_Left.Y), New Point(zP_Right.X, zP_Right.Y), New Point(zP_Left.X, zP_Right.Y), New Point(zP_Left.X, zP_Left.Y)}
            If zBorderLines_Show = True Then
                Using Pen As New Pen(zBorderLines_Color, zBorderLines_Thickness)
                    Pen.DashStyle = zBorderLines_Style
                    e.Graphics.DrawLines(Pen, zBorderLines_Points)
                    zGP_BorderLines.AddLines(zBorderLines_Points)
                    zGP_BorderLines.CloseFigure()
                    '   BorderThickness and Style for SeeThroughMode
                    Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
                    zGP_BorderLines.Widen(Pen)
                End Using
            End If


            ' --- MarginLines 
            If zMarginLines_Show = True AndAlso zMarginLines_Side > LineNumberDockside.None Then
                zP_Left = New Point(CInt((-zMarginLines_Thickness)), CInt((-zMarginLines_Thickness)))
                zP_Right = New Point(CInt((Me.Width + zMarginLines_Thickness)), CInt((Me.Height + zMarginLines_Thickness)))
                Using Pen As New Pen(zMarginLines_Color, zMarginLines_Thickness)
                    zPen.DashStyle = zMarginLines_Style
                    If zMarginLines_Side = LineNumberDockside.Left Or zMarginLines_Side = LineNumberDockside.Height Then
                        e.Graphics.DrawLine(Pen, New Point(CInt((Math.Floor(zMarginLines_Thickness / 2))), 0), New Point(CInt((Math.Floor(zMarginLines_Thickness / 2))), Me.Height - 1))
                        zP_Left = New Point(CInt((Math.Ceiling(zMarginLines_Thickness / 2))), CInt((-zMarginLines_Thickness)))
                    End If
                    If zMarginLines_Side = LineNumberDockside.Right Or zMarginLines_Side = LineNumberDockside.Height Then
                        e.Graphics.DrawLine(Pen, New Point(CInt((Me.Width - Math.Ceiling(zMarginLines_Thickness / 2))), 0), New Point(CInt((Me.Width - Math.Ceiling(zMarginLines_Thickness / 2))), CInt((Me.Height - 1))))

                        zP_Right = New Point(CInt((Me.Width - Math.Ceiling(zMarginLines_Thickness / 2))), CInt((Me.Height + zMarginLines_Thickness)))
                    End If
                    '   GraphicsPath for the MarginLines(s):
                    '   MarginLines(s) are drawn as a rectangle connecting the zP_Left and zP_Right points, which are either inside or 
                    '   outside of sight, depending on whether the MarginLines at that side is visible. zP_Left: TopLeft and ZP_Right: BottomRight
                    zGP_MarginLines.AddRectangle(New Rectangle(zP_Left, New Size(zP_Right.X - zP_Left.X, zP_Right.Y - zP_Left.Y)))
                    zPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
                    zGP_MarginLines.Widen(Pen)
                End Using
            End If
            ' ----------------------------------------------
            ' --- SeeThroughMode
            '   combine all the GraphicsPaths (= zGP_... ) and set them as the region for the control.
            If zSeeThroughMode = True Then
                zRegion.MakeEmpty()
                zRegion.Union(zGP_BorderLines)
                zRegion.Union(zGP_MarginLines)
                zRegion.Union(zGP_GridLines)
                zRegion.Union(zGP_LineNumbers)
            End If

            ' --- Region
            If zRegion.GetBounds(e.Graphics).IsEmpty = True Then
                '   Note: If the control is in a condition that would show it as empty, then a border-region is still drawn regardless of it's borders on/off state.
                '   This is added to make sure that the bounds of the control are never lost (it would remain empty if this was not done).
                zGP_BorderLines.AddLines(zBorderLines_Points)
                zGP_BorderLines.CloseFigure()
                Using Pen As New Pen(zBorderLines_Color, 1)
                    Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
                    zGP_BorderLines.Widen(Pen)
                End Using
                zRegion = New Region(zGP_BorderLines)
            End If
            Me.Region = zRegion


            ' ----------------------------------------------
            ' --- Memory CleanUp
            If zPen IsNot Nothing Then
                zPen.Dispose()
            End If
            If zBrush IsNot Nothing Then
                zBrush.Dispose()
            End If
            If zRegion IsNot Nothing Then
                zRegion.Dispose()
            End If
            If zGP_GridLines IsNot Nothing Then
                zGP_GridLines.Dispose()
            End If
            If zGP_BorderLines IsNot Nothing Then
                zGP_BorderLines.Dispose()
            End If
            If zGP_MarginLines IsNot Nothing Then
                zGP_MarginLines.Dispose()
            End If
            If zGP_LineNumbers IsNot Nothing Then
                zGP_LineNumbers.Dispose()
            End If

        End Sub
        Private Sub zTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs)
            zParentIsScrolling = False
            zTimer.[Stop]()
            Me.Invalidate()
        End Sub

        Private Sub zParent_Changed(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.Refresh()
            Me.Invalidate()
        End Sub

        Private Sub zParent_Scroll(ByVal sender As Object, ByVal e As System.EventArgs)
            zParentIsScrolling = True
            Me.Invalidate()
        End Sub

        Private Sub zParent_ContentsResized(ByVal sender As Object, ByVal e As System.Windows.Forms.ContentsResizedEventArgs)
            zContentRectangle = e.NewRectangle
            Me.Refresh()
            Me.Invalidate()
        End Sub

        Private Sub zParent_Disposed(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.ParentRichTextBox = Nothing
            Me.Refresh()
            Me.Invalidate()
        End Sub

    End Class
End Namespace