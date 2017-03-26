namespace TTTAttributedLabelBindings {

	public enum NSTextCheckingTypes : ulong {
		AllSystemTypes = 0xffffffff,
		AllCustomTypes = 0xffffffff00000000,
		AllTypes = 0xffffffffffffffff
	}

	public enum NSTextCheckingType : ulong {
		Orthography   = 1 << 0,
		Spelling      = 1 << 1,
		Grammar       = 1 << 2,
		Date          = 1 << 3,
		Address       = 1 << 4,
		Link          = 1 << 5,
		Quote         = 1 << 6,
		Dash          = 1 << 7,
		Replacement   = 1 << 8,
		Correction    = 1 << 9 
	}

	public enum TTTAttributedLabelVerticalAlignment {
		Center = 0,
		Top = 1,
		Bottom = 2
	}

}