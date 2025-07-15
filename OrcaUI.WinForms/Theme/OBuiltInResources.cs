using System.Globalization;

namespace OrcaUI.WinForms.Theme
{

    public abstract class OUIBuiltInResources
    {
        public abstract CultureInfo CultureInfo { get; }

        /// <summary>
        /// Hint / Notification / Prompt
        /// </summary>
        public virtual string InfoTitle { get; set; } = "Hint";

        /// <summary>
        /// Correct
        /// </summary>
        public virtual string SuccessTitle { get; set; } = "Correct";

        /// <summary>
        /// Warning
        /// </summary>
        public virtual string WarningTitle { get; set; } = "Warning";

        /// <summary>
        /// Error
        /// </summary>
        public virtual string ErrorTitle { get; set; } = "Error";

        /// <summary>
        /// Prompt
        /// </summary>
        public virtual string AskTitle { get; set; } = "Prompt";

        /// <summary>
        /// Input
        /// </summary>
        public virtual string InputTitle { get; set; } = "Input";

        /// <summary>
        /// Selection
        /// </summary>
        public virtual string SelectTitle { get; set; } = "Selection";

        /// <summary>
        /// Close All
        /// </summary>
        public virtual string CloseAll { get; set; } = "Close All";

        /// <summary>
        /// Confirm
        /// </summary>
        public virtual string OK { get; set; } = "Confirm";

        /// <summary>
        /// Cancel
        /// </summary>
        public virtual string Cancel { get; set; } = "Cancel";

        /// <summary>
        /// [ No Data ]
        /// </summary>
        public virtual string GridNoData { get; set; } = "[ No Data ]";

        /// <summary>
        /// Data is loading, please wait...
        /// </summary>
        public virtual string GridDataLoading { get; set; } = "Data is loading, please wait...";

        /// <summary>
        /// The data source must be a DataTable or a List
        /// </summary>
        public virtual string GridDataSourceException { get; set; } = "The data source must be a DataTable or a List";

        /// <summary>
        /// "The system is processing, please wait..."
        /// </summary>
        public virtual string SystemProcessing { get; set; } = "The system is processing, please wait...";

        /// <summary>
        /// Monday
        /// </summary>
        public virtual string Monday { get; set; } = "Mon";

        /// <summary>
        /// Tuesday
        /// </summary>
        public virtual string Tuesday { get; set; } = "Tue";

        /// <summary>
        /// Wednesday
        /// </summary>
        public virtual string Wednesday { get; set; } = "Wed";

        /// <summary>
        /// Thursday
        /// </summary>
        public virtual string Thursday { get; set; } = "Thu";

        /// <summary>
        /// Friday
        /// </summary>
        public virtual string Friday { get; set; } = "Fri";

        /// <summary>
        /// Saturday
        /// </summary>
        public virtual string Saturday { get; set; } = "Sat";

        /// <summary>
        /// Sunday
        /// </summary>
        public virtual string Sunday { get; set; } = "Sun";

        /// <summary>
        /// Previous Page
        /// </summary>
        public virtual string Prev { get; set; } = "Previous Page";

        /// <summary>
        /// Next Page
        /// </summary>
        public virtual string Next { get; set; } = "Next Page";

        /// <summary>
        /// Page (prefix)
        /// </summary>
        public virtual string SelectPageLeft { get; set; } = "Page ";

        /// <summary>
        /// Page (suffix)
        /// </summary>
        public virtual string SelectPageRight { get; set; } = "";

        /// <summary>
        /// January
        /// </summary>
        public virtual string January { get; set; } = "January";

        /// <summary>
        /// February
        /// </summary>
        public virtual string February { get; set; } = "February";

        /// <summary>
        /// March
        /// </summary>
        public virtual string March { get; set; } = "March";

        /// <summary>
        /// April
        /// </summary>
        public virtual string April { get; set; } = "April";

        /// <summary>
        /// May
        /// </summary>
        public virtual string May { get; set; } = "May";

        /// <summary>
        /// June
        /// </summary>
        public virtual string June { get; set; } = "June";

        /// <summary>
        /// July
        /// </summary>
        public virtual string July { get; set; } = "July";

        /// <summary>
        /// August
        /// </summary>
        public virtual string August { get; set; } = "August";

        /// <summary>
        /// September
        /// </summary>
        public virtual string September { get; set; } = "September";

        /// <summary>
        /// October
        /// </summary>
        public virtual string October { get; set; } = "October";

        /// <summary>
        /// November
        /// </summary>
        public virtual string November { get; set; } = "November";

        /// <summary>
        /// December
        /// </summary>
        public virtual string December { get; set; } = "December";

        /// <summary>
        /// Today
        /// </summary>
        public virtual string Today { get; set; } = "Today";

        /// <summary>
        /// Search
        /// </summary>
        public virtual string Search { get; set; } = "Search";

        /// <summary>
        /// Clear
        /// </summary>
        public virtual string Clear { get; set; } = "Clear";

        public virtual string Open { get; set; } = "Open";
        public virtual string Save { get; set; } = "Save";

        public virtual string All { get; set; } = "All";

        public virtual string EditorCantEmpty { get; set; } = "Editor content cannot be empty.";

    }
}
