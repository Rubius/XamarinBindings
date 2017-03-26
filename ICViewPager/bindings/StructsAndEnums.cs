using ObjCRuntime;

[Native]
public enum ViewPagerOption : ulong
{
	TabHeight,
	TabOffset,
	TabWidth,
	TabLocation,
	StartFromSecondTab,
	CenterCurrentTab,
	FixFormerTabsPositions,
	FixLatterTabsPositions
}

[Native]
public enum ViewPagerComponent : ulong
{
	Indicator,
	TabsView,
	Content
}
