using System.Drawing;
using System;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;

namespace MDSpreadViewBinding {

	[BaseType (typeof (UIView))]
	public partial interface MDSpreadViewCell : UIGestureRecognizerDelegate {

		[Export ("initWithStyle:reuseIdentifier:")]
		IntPtr Constructor (MDSpreadViewCellStyle style, string reuseIdentifier);

		[Export ("reuseIdentifier", ArgumentSemantic.Copy)]
		string ReuseIdentifier { get; }

		[Export ("prepareForReuse")]
		void PrepareForReuse ();

		[Export ("style")]
		int Style { get; }

		[Export ("textLabel", ArgumentSemantic.Retain)]
		UILabel TextLabel { get; }

		[Export ("detailTextLabel", ArgumentSemantic.Retain)]
		UILabel DetailTextLabel { get; }

		[Export ("backgroundView", ArgumentSemantic.Retain)]
		UIView BackgroundView { get; set; }

		[Export ("highlightedBackgroundView", ArgumentSemantic.Retain)]
		UIView HighlightedBackgroundView { get; set; }

		[Export ("highlighted")]
		bool Highlighted { [Bind ("isHighlighted")] get; set; }

		[Export ("setHighlighted:animated:")]
		void SetHighlighted (bool isHighlighted, bool animated);

		[Export ("objectValue", ArgumentSemantic.Retain)]
		NSObject ObjectValue { get; set; }
	}


	[Model, BaseType (typeof (NSObject))]
	public partial interface MDSpreadViewDelegate : UIScrollViewDelegate {

		[Export ("spreadView:willDisplayCell:forRowAtIndexPath:forColumnAtIndexPath:")]
		void WillDisplayCell (MDSpreadView aSpreadView, MDSpreadViewCell cell, MDIndexPath rowPath, MDIndexPath columnPath);

		[Export ("spreadView:willDisplayCell:forHeaderInRowSection:forColumnSection:")]
		void WillDisplayCell (MDSpreadView aSpreadView, MDSpreadViewCell cell, int rowSection, int columnSection);

		[Export ("spreadView:willDisplayCell:forHeaderInRowSection:forColumnAtIndexPath:")]
		void WillDisplayCell (MDSpreadView aSpreadView, MDSpreadViewCell cell, int section, MDIndexPath columnPath);

		[Export ("spreadView:willDisplayCell:forHeaderInColumnSection:forRowAtIndexPath:")]
		void WillDisplayCell (MDSpreadView aSpreadView, MDSpreadViewCell cell, int section, MDIndexPath rowPath);

		[Export ("spreadView:heightForRowAtIndexPath:")]
		float HeightForRowAtIndexPath (MDSpreadView aSpreadView, MDIndexPath indexPath);

		[Export ("spreadView:heightForRowHeaderInSection:")]
		float HeightForRowHeaderInSection (MDSpreadView aSpreadView, int rowSection);

		[Export ("spreadView:widthForColumnAtIndexPath:")]
		float WidthForColumnAtIndexPath (MDSpreadView aSpreadView, MDIndexPath indexPath);

		[Export ("spreadView:widthForColumnHeaderInSection:")]
		float WidthForColumnHeaderInSection (MDSpreadView aSpreadView, int columnSection);

		[Export ("spreadView:willSelectCellForSelection:")]
		MDSpreadViewSelection WillSelectCellForSelection (MDSpreadView aSpreadView, MDSpreadViewSelection selection);

		[Export ("spreadView:didSelectCellForRowAtIndexPath:forColumnAtIndexPath:")]
		void DidSelectCellForRowAtIndexPath (MDSpreadView aSpreadView, MDIndexPath rowPath, MDIndexPath columnPath);
	}

	[BaseType (typeof (UIScrollView))]
	public partial interface MDSpreadView {

		[Export ("dataSource", ArgumentSemantic.Assign)]
		MDSpreadViewDataSource DataSource { get; set; }

		[Export ("delegate", ArgumentSemantic.Assign)]
		MDSpreadViewDelegate Delegate { get; set; }

		[Export ("rowHeight")]
		float RowHeight { get; set; }

		[Export ("sectionRowHeaderHeight")]
		float SectionRowHeaderHeight { get; set; }

		[Export ("columnWidth")]
		float ColumnWidth { get; set; }

		[Export ("sectionColumnHeaderWidth")]
		float SectionColumnHeaderWidth { get; set; }

		[Export ("defaultHeaderCornerCellClass")]
		Class DefaultHeaderCornerCellClass { get; set; }

		[Export ("defaultHeaderColumnCellClass")]
		Class DefaultHeaderColumnCellClass { get; set; }

		[Export ("defaultHeaderRowCellClass")]
		Class DefaultHeaderRowCellClass { get; set; }

		[Export ("defaultCellClass")]
		Class DefaultCellClass { get; set; }

		[Export ("reloadData")]
		void ReloadData ();

		[Export ("numberOfRowSections"), Verify ("ObjC method massaged into getter property", "/Users/Adn/Projects/MDSpreadView/MDSpreadView/MDSpreadView/MDSpreadView.h", Line = 213)]
		int NumberOfRowSections { get; }

		[Export ("numberOfRowsInRowSection:")]
		int NumberOfRowsInRowSection (int section);

		[Export ("numberOfColumnSections"), Verify ("ObjC method massaged into getter property", "/Users/Adn/Projects/MDSpreadView/MDSpreadView/MDSpreadView/MDSpreadView.h", Line = 215)]
		int NumberOfColumnSections { get; }

		[Export ("numberOfColumnsInColumnSection:")]
		int NumberOfColumnsInColumnSection (int section);

		[Export ("rectForRowSection:columnSection:")]
		RectangleF RectForRowSection (int rowSection, int columnSection);

		[Export ("cellRectForRowAtIndexPath:forColumnAtIndexPath:")]
		RectangleF CellRectForRowAtIndexPath (MDIndexPath rowPath, MDIndexPath columnPath);

		[Export ("selectionMode")]
		MDSpreadViewSelectionMode SelectionMode { get; set; }

		[Export ("allowsSelection")]
		bool AllowsSelection { get; set; }

		[Export ("allowsMultipleSelection")]
		bool AllowsMultipleSelection { get; set; }

		[Export ("selectCellForRowAtIndexPath:forColumnAtIndexPath:withSelectionMode:animated:scrollPosition:")]
		void SelectCellForRowAtIndexPath (MDIndexPath rowPath, MDIndexPath columnPath, MDSpreadViewSelectionMode mode, bool animated, MDSpreadViewScrollPosition scrollPosition);

		[Export ("deselectCellForRowAtIndexPath:forColumnAtIndexPath:animated:")]
		void DeselectCellForRowAtIndexPath (MDIndexPath rowPath, MDIndexPath columnPath, bool animated);

		[Export ("dequeueReusableCellWithIdentifier:")]
		MDSpreadViewCell DequeueReusableCellWithIdentifier (string identifier);

		[Export ("sortDescriptors", ArgumentSemantic.Copy), Verify ("NSArray may be reliably typed, check the documentation", "/Users/Adn/Projects/MDSpreadView/MDSpreadView/MDSpreadView/MDSpreadView.h", Line = 270)]
		NSObject [] SortDescriptors { get; set; }
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface MDSpreadViewDataSource {

		[Export ("spreadView:numberOfColumnsInSection:")]
		int SpreadView (MDSpreadView aSpreadView, int section);

		[Export ("spreadView:numberOfRowsInSection:")]
		int SpreadView (MDSpreadView aSpreadView, int section);

		[Export ("spreadView:cellForRowAtIndexPath:forColumnAtIndexPath:")]
		MDSpreadViewCell SpreadView (MDSpreadView aSpreadView, MDIndexPath rowPath, MDIndexPath columnPath);

		[Export ("numberOfColumnSectionsInSpreadView:")]
		int NumberOfColumnSectionsInSpreadView (MDSpreadView aSpreadView);

		[Export ("numberOfRowSectionsInSpreadView:")]
		int NumberOfRowSectionsInSpreadView (MDSpreadView aSpreadView);

		[Export ("spreadView:titleForHeaderInRowSection:forColumnSection:")]
		NSObject SpreadView (MDSpreadView aSpreadView, int rowSection, int columnSection);

		[Export ("spreadView:titleForHeaderInRowSection:forColumnAtIndexPath:")]
		NSObject SpreadView (MDSpreadView aSpreadView, int section, MDIndexPath columnPath);

		[Export ("spreadView:titleForHeaderInColumnSection:forRowAtIndexPath:")]
		NSObject SpreadView (MDSpreadView aSpreadView, int section, MDIndexPath rowPath);

		[Export ("spreadView:objectValueForRowAtIndexPath:forColumnAtIndexPath:")]
		NSObject SpreadView (MDSpreadView aSpreadView, MDIndexPath rowPath, MDIndexPath columnPath);

		[Export ("spreadView:cellForHeaderInRowSection:forColumnSection:")]
		MDSpreadViewCell SpreadView (MDSpreadView aSpreadView, int rowSection, int columnSection);

		[Export ("spreadView:cellForHeaderInRowSection:forColumnAtIndexPath:")]
		MDSpreadViewCell SpreadView (MDSpreadView aSpreadView, int section, MDIndexPath columnPath);

		[Export ("spreadView:cellForHeaderInColumnSection:forRowAtIndexPath:")]
		MDSpreadViewCell SpreadView (MDSpreadView aSpreadView, int section, MDIndexPath rowPath);

		[Export ("spreadView:sortDescriptorsDidChange:")]
		void SpreadView (MDSpreadView aSpreadView, [Verify ("NSArray may be reliably typed, check the documentation", "/Users/Adn/Projects/MDSpreadView/MDSpreadView/MDSpreadView/MDSpreadView.h", Line = 309)] NSObject [] oldDescriptors);
	}

	[BaseType (typeof (NSObject))]
	public partial interface MDIndexPath {

		[Static, Export ("indexPathForColumn:inSection:")]
		MDIndexPath IndexPathForColumn (int column, int section);

		[Static, Export ("indexPathForRow:inSection:")]
		MDIndexPath IndexPathForRow (int row, int section);

		[Export ("section")]
		int Section { get; }

		[Export ("row")]
		int Row { get; }

		[Export ("column")]
		int Column { get; }

		[Export ("isEqualToIndexPath:")]
		bool IsEqualToIndexPath (MDIndexPath obj);
	}


	[BaseType (typeof (NSSortDescriptor))]
	public partial interface MDSortDescriptor {

		[Export ("indexPath", ArgumentSemantic.Retain)]
		MDIndexPath IndexPath { get; }

		[Export ("section")]
		int Section { get; }

		[Export ("sortAxis")]
		MDSpreadViewSortAxis SortAxis { get; }

		[Static, Export ("sortDescriptorWithKey:ascending:selectsWholeSpreadView:")]
		NSObject SortDescriptorWithKey (string key, bool ascending, bool wholeView);

		[Static, Export ("sortDescriptorWithKey:ascending:selector:selectsWholeSpreadView:")]
		NSObject SortDescriptorWithKey (string key, bool ascending, Selector selector, bool wholeView);

		[Static, Export ("sortDescriptorWithKey:ascending:comparator:selectsWholeSpreadView:")]
		NSObject SortDescriptorWithKey (string key, bool ascending, NSComparator cmptr, bool wholeView);

		[Export ("initWithKey:ascending:selectsWholeSpreadView:")]
		IntPtr Constructor (string key, bool ascending, bool wholeView);

		[Export ("initWithKey:ascending:selector:selectsWholeSpreadView:")]
		IntPtr Constructor (string key, bool ascending, Selector selector, bool wholeView);

		[Export ("initWithKey:ascending:comparator:selectsWholeSpreadView:")]
		IntPtr Constructor (string key, bool ascending, NSComparator cmptr, bool wholeView);
	}

	[BaseType (typeof (NSObject))]
	public partial interface MDSpreadViewSelection {

		[Export ("rowPath", ArgumentSemantic.Retain)]
		MDIndexPath RowPath { get; }

		[Export ("columnPath", ArgumentSemantic.Retain)]
		MDIndexPath ColumnPath { get; }

		[Export ("selectionMode")]
		MDSpreadViewSelectionMode SelectionMode { get; }

		[Static, Export ("selectionWithRow:column:mode:")]
		NSObject SelectionWithRow (MDIndexPath row, MDIndexPath column, MDSpreadViewSelectionMode mode);
	}



	[BaseType (typeof (UIView))]
	public partial interface MDSpreadViewCellBackground {

		[Export ("highlighted")]
		bool Highlighted { [Bind ("isHighlighted")] get; set; }

		[Export ("prepareBackground")]
		void PrepareBackground ();

		[Export ("layoutBackground")]
		void LayoutBackground ();
	}




	[BaseType (typeof (MDSpreadViewCell))]
	public partial interface MDSpreadViewHeaderCell {

		[Export ("initWithStyle:reuseIdentifier:")]
		IntPtr Constructor (MDSpreadViewHeaderCellStyle style, string reuseIdentifier);

		[Export ("sortDescriptorPrototype", ArgumentSemantic.Retain)]
		MDSortDescriptor SortDescriptorPrototype { get; set; }

		[Export ("defaultSortAxis")]
		MDSpreadViewSortAxis DefaultSortAxis { get; set; }
	}



}
