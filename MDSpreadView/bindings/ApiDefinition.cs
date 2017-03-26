using System.Drawing;
using System;

using ObjCRuntime;
using Foundation;
using UIKit;
using CoreGraphics;

namespace MDSpreadSheetViewBinding {

	[BaseType (typeof (UIView))]
	public partial interface MDSpreadViewCell  {

		[Export ("initWithStyle:reuseIdentifier:")]
		IntPtr Constructor (MDSpreadViewCellStyle style, string reuseIdentifier);

		[Export ("reuseIdentifier", ArgumentSemantic.Copy)]
		string ReuseIdentifier { get; }

		[Export ("prepareForReuse")]
		void PrepareForReuse ();

		[Export ("style")]
		nint Style { get; }

		[Export ("textLabel", ArgumentSemantic.Retain)]
		UILabel TextLabel { get; }

		[Export ("detailTextLabel", ArgumentSemantic.Retain)]
		UILabel DetailTextLabel { get; }

		[Export ("hasSeparators") ]
		bool HasSeparators { get; }

		[Export ("backgroundView", ArgumentSemantic.Retain)]
		UIView BackgroundView { get; set; }

		[Export ("selectedBackgroundView", ArgumentSemantic.Retain)]
		UIView SelectedBackgroundView { get; set; }

		[Export ("highlightedBackgroundView", ArgumentSemantic.Retain)]
		UIView HighlightedBackgroundView { get; set; }

		[Export ("selectionStyle")]
		MDSpreadViewCellSelectionStyle SelectionStyle { get; set; }

		[Export ("selected")]
		bool Selected { [Bind ("isSelected")] get; set; }

		[Export ("highlighted")]
		bool Highlighted { [Bind ("isHighlighted")] get; set; }

		[Export ("setSelected:animated:")]
		void SetSelected (bool isSelected, bool animated);

		[Export ("setHighlighted:animated:")]
		void SetHighlighted (bool isHighlighted, bool animated);

		[Export ("objectValue", ArgumentSemantic.Retain)]
		NSObject ObjectValue { get; set; }
		
		[Export ("_handleTap:")]
		void HandleTap(UIGestureRecognizer gesture);
	}


	[Model]
	[BaseType (typeof(UIScrollViewDelegate))]
	[Protocol]
	public partial interface MDSpreadViewDelegate {

		[Export ("spreadView:willDisplayCell:forRowAtIndexPath:forColumnAtIndexPath:")]
		void WillDisplayCell (MDSpreadView aSpreadView, MDSpreadViewCell cell, MDIndexPath rowPath, MDIndexPath columnPath);

		[Export ("spreadView:willDisplayCell:forHeaderInRowSection:forColumnSection:")]
		void WillDisplayHeaderInRowSection (MDSpreadView aSpreadView, MDSpreadViewCell cell, nint rowSection, nint columnSection);

		[Export ("spreadView:willDisplayCell:forHeaderInRowSection:forColumnAtIndexPath:")]
		void WillDisplayRowHeader (MDSpreadView aSpreadView, MDSpreadViewCell cell, nint section, MDIndexPath columnPath);

		[Export ("spreadView:willDisplayCell:forHeaderInColumnSection:forRowAtIndexPath:")]
		void WillDisplayColumnHeader (MDSpreadView aSpreadView, MDSpreadViewCell cell, nint section, MDIndexPath rowPath);

		[Export ("spreadView:willDisplayCell:forHeaderInRowSection:forColumnFooterSection:")]
		void WillDisplayHeaderInRowSectionForFooter (MDSpreadView aSpreadView, MDSpreadViewCell cell, nint rowSection, nint columnSection);

		[Export ("spreadView:willDisplayCell:forHeaderInColumnSection:forRowFooterSection:")]
		void WillDisplayHeaderInColumnSection (MDSpreadView aSpreadView, MDSpreadViewCell cell, nint columnSection, nint rowSection);

		[Export ("spreadView:willDisplayCell:forFooterInRowSection:forColumnSection:")]
		void WillDisplayFooterInRowSectionForColumnSection (MDSpreadView aSpreadView, MDSpreadViewCell cell, nint rowSection, nint columnSection);

		[Export ("spreadView:willDisplayCell:forFooterInRowSection:forColumnAtIndexPath:")]
		void WillDisplayFooterInRowSectionForColumn (MDSpreadView aSpreadView, MDSpreadViewCell cell, nint section, MDIndexPath columnPath);

		[Export ("spreadView:willDisplayCell:forFooterInColumnSection:forRowAtIndexPath:")]
		void WillDisplayFooterInColumnSection (MDSpreadView aSpreadView, MDSpreadViewCell cell, nint section, MDIndexPath rowPath);

		[Export ("spreadView:heightForRowAtIndexPath:")]
		nfloat HeightForRowAtIndexPath (MDSpreadView aSpreadView, MDIndexPath indexPath);

		[Export ("spreadView:heightForRowHeaderInSection:")]
		nfloat HeightForRowHeaderInSection (MDSpreadView aSpreadView, nint rowSection);

		[Export ("spreadView:heightForRowFooterInSection:")]
		nfloat HeightForRowFooterInSection (MDSpreadView aSpreadView, nint rowSection);

		[Export ("spreadView:widthForColumnAtIndexPath:")]
		nfloat WidthForColumnAtIndexPath (MDSpreadView aSpreadView, MDIndexPath indexPath);

		[Export ("spreadView:widthForColumnHeaderInSection:")]
		nfloat WidthForColumnHeaderInSection (MDSpreadView aSpreadView, nint columnSection);

		[Export ("spreadView:widthForColumnFooterInSection:")]
		nfloat WidthForColumnFooterInSection (MDSpreadView aSpreadView, nint columnSection);

		[Export ("spreadView:willHighlightCellWithSelection:")]
		MDSpreadViewSelection WillHighlightCellWithSelection (MDSpreadView aSpreadView, MDSpreadViewSelection selection);

		[Export ("spreadView:didHighlightCellForRowAtIndexPath:forColumnAtIndexPath:")]
		void DidHighlightCellForRowAtIndexPath (MDSpreadView aSpreadView, MDIndexPath rowPath, MDIndexPath columnPath);

		[Export ("spreadView:didUnhighlightCellForRowAtIndexPath:forColumnAtIndexPath:")]
		void DidUnhighlightCellForRowAtIndexPath (MDSpreadView aSpreadView, MDIndexPath rowPath, MDIndexPath columnPath);

		[Export ("spreadView:willSelectCellWithSelection:")]
		MDSpreadViewSelection WillSelectCellWithSelection (MDSpreadView aSpreadView, MDSpreadViewSelection selection);

		[Export ("spreadView:willDeselectCellWithSelection:")]
		MDSpreadViewSelection WillDeselectCellWithSelection (MDSpreadView aSpreadView, MDSpreadViewSelection selection);

		[Export ("spreadView:didSelectCellForRowAtIndexPath:forColumnAtIndexPath:")]
		void DidSelectCellForRowAtIndexPath (MDSpreadView aSpreadView, MDIndexPath rowPath, MDIndexPath columnPath);

		[Export ("spreadView:didDeselectCellForRowAtIndexPath:forColumnAtIndexPath:")]
		void DidDeselectCellForRowAtIndexPath (MDSpreadView aSpreadView, MDIndexPath rowPath, MDIndexPath columnPath);
	}

	[BaseType (typeof (UIScrollView))]
	public partial interface MDSpreadView {

		[Export ("dataSource", ArgumentSemantic.Assign)]
		MDSpreadViewDataSource DataSource { get; set; }

		[Export ("delegate", ArgumentSemantic.Assign)]
		MDSpreadViewDelegate Delegate { get; set; }

		[Export ("rowHeight")]
		nfloat RowHeight { get; set; }

		[Export ("sectionRowHeaderHeight")]
		nfloat SectionRowHeaderHeight { get; set; }

		[Export ("columnWidth")]
		nfloat ColumnWidth { get; set; }

		[Export ("sectionColumnHeaderWidth")]
		nfloat SectionColumnHeaderWidth { get; set; }

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

		[Export ("numberOfRowSections"), ]
		nint NumberOfRowSections { get; }

		[Export ("numberOfRowsInRowSection:")]
		nint NumberOfRowsInRowSection (nint section);

		[Export ("numberOfColumnSections")]
		nint NumberOfColumnSections { get; }

		[Export ("numberOfColumnsInColumnSection:")]
		nint NumberOfColumnsInColumnSection (nint section);

		[Export ("rectForRowSection:columnSection:")]
		CGRect RectForRowSection (nint rowSection, nint columnSection);

		[Export ("cellRectForRowAtIndexPath:forColumnAtIndexPath:")]
		CGRect CellRectForRowAtIndexPath (MDIndexPath rowPath, MDIndexPath columnPath);

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

		[Export ("sortDescriptors", ArgumentSemantic.Copy)]
		NSObject [] SortDescriptors { get; set; }
	}

	[Model, BaseType (typeof (NSObject))]
	[Protocol]
	public partial interface MDSpreadViewDataSource {

		[Export ("spreadView:numberOfColumnsInSection:")]
		nint SpreadViewnumberOfColumnsInSection (MDSpreadView aSpreadView, nint section);

		[Export ("spreadView:numberOfRowsInSection:")]
		nint SpreadViewnumberOfRowsInSection (MDSpreadView aSpreadView, nint section);

		[Export ("spreadView:cellForRowAtIndexPath:forColumnAtIndexPath:")]
		MDSpreadViewCell SpreadViewcellForRowAtIndexPathforColumnAtIndexPath (MDSpreadView aSpreadView, MDIndexPath rowPath, MDIndexPath columnPath);

		[Export ("numberOfColumnSectionsInSpreadView:")]
		nint NumberOfColumnSectionsInSpreadView (MDSpreadView aSpreadView);

		[Export ("numberOfRowSectionsInSpreadView:")]
		nint NumberOfRowSectionsInSpreadView (MDSpreadView aSpreadView);

		[Export ("spreadView:titleForHeaderInRowSection:forColumnSection:")]
		NSObject SpreadViewtitleForHeaderInRowSectionforColumnSection (MDSpreadView aSpreadView, nint rowSection, nint columnSection);

		[Export ("spreadView:titleForHeaderInRowSection:forColumnAtIndexPath:")]
		NSObject SpreadViewtitleForHeaderInRowSectionforColumnAtIndexPath (MDSpreadView aSpreadView, nint section, MDIndexPath columnPath);

		[Export ("spreadView:titleForHeaderInColumnSection:forRowAtIndexPath:")]
		NSObject SpreadViewtitleForHeaderInColumnSectionforRowAtIndexPath (MDSpreadView aSpreadView, nint section, MDIndexPath rowPath);

		[Export ("spreadView:objectValueForRowAtIndexPath:forColumnAtIndexPath:")]
		NSObject SpreadViewobjectValueForRowAtIndexPathforColumnAtIndexPath (MDSpreadView aSpreadView, MDIndexPath rowPath, MDIndexPath columnPath);

		[Export ("spreadView:cellForHeaderInRowSection:forColumnSection:")]
		MDSpreadViewCell SpreadViewcellForHeaderInRowSectionforColumnSection (MDSpreadView aSpreadView, nint rowSection, nint columnSection);

		[Export ("spreadView:cellForHeaderInRowSection:forColumnAtIndexPath:")]
		MDSpreadViewCell SpreadViewcellForHeaderInRowSectionforColumnAtIndexPath (MDSpreadView aSpreadView, nint section, MDIndexPath columnPath);

		[Export ("spreadView:cellForHeaderInColumnSection:forRowAtIndexPath:")]
		MDSpreadViewCell SpreadViewcellForHeaderInColumnSectionforRowAtIndexPath (MDSpreadView aSpreadView, nint section, MDIndexPath rowPath);

		[Export ("spreadView:sortDescriptorsDidChange:")]
		void SpreadViewsortDescriptorsDidChange (MDSpreadView aSpreadView, NSObject [] oldDescriptors);
	}

	[BaseType (typeof (NSObject))]
	public partial interface MDIndexPath {

		[Static, Export ("indexPathForColumn:inSection:")]
		MDIndexPath IndexPathForColumn (nint column, nint section);

		[Static, Export ("indexPathForRow:inSection:")]
		MDIndexPath IndexPathForRow (nint row, nint section);

		[Export ("section")]
		nint Section { get; }

		[Export ("row")]
		nint Row { get; }

		[Export ("column")]
		nint Column { get; }

		[Export ("isEqualToIndexPath:")]
		bool IsEqualToIndexPath (MDIndexPath obj);
	}


	[BaseType (typeof (NSSortDescriptor))]
	public partial interface MDSortDescriptor {

		[Export ("indexPath", ArgumentSemantic.Retain)]
		MDIndexPath IndexPath { get; }

		[Export ("section")]
		nint Section { get; }

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
