namespace MDSpreadSheetViewBinding {

	public enum MDSpreadViewCellStyle  {
		Default
	}

	public enum MDSpreadViewCellSeparatorStyle {
		None,
		Horizontal,
		Vertical,
		Corner
	}

	public enum MDSpreadViewCellSelectionStyle  {
		None,
		Default
	}

	public enum MDSpreadViewCellAccessoryType {
		None,
		DisclosureIndicator
	}

	public enum MDSpreadViewSortAxis {
		None,
		Columns,
		Rows,
		Both
	}

	public enum MDSpreadViewHeaderCellStyle {
		Corner,
		Row,
		Column
	}


	public enum MDSpreadViewScrollPosition  {
		None,
		Automatic,
		TopLeft,
		TopMiddle,
		TopRight,
		CenterLeft,
		CenterMiddle,
		CenterRight,
		BottomLeft,
		BottomMiddle,
		BottomRight
	}

	public enum MDSpreadViewSelectionMode{
		None,
		Automatic,
		Cell,
		Row,
		Column,
		RowAndColumn
	}

	public enum MDSpreadViewCellDomain{
		Headers = -1,
		Cells = 0,
		Footers = 1
	}

	public enum MDSpreadViewCellResizing  {
		None,
		Uniform,
		CellsOnly,
		HeadersOnly,
		FootersOnly,
		FirstHeader,
		LastFooter,
		FirstCell,
		LastCell
	}
}