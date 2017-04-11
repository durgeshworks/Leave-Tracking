$(document).ready(function () {

    setDefaultDateOnLoad();

  $('#inputDate').change(function () {
      loadDatesByCurrentDate(this.value);
  });

  

  //$('#inputDate').datepicker({
  //    changeMonth: true,
  //    changeYear: true
  //    //}).on('change', function ()
  //    //{
  //    //    loadDatesByCurrentDate(window.inputDate.value);
  //});

    
});

function setDefaultDateOnLoad() {

    $('#inputDate').changeMonth = true;
    $('#inputDate').changeYear = true;

    

    var now = new Date();
    var day = ("0" + now.getDate()).slice(-2);
    var month = ("0" + (now.getMonth() + 1)).slice(-2);
    var today = now.getFullYear() + "-" + (month) + "-" + (day);
    $('#inputDate').val(today);
    loadDatesByCurrentDate(today);

}

function loadDatesByCurrentDate(setDate) {
    //alert(setDate);
    var weekdays = new Array("Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat");
    var months = new Array("Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec");
    var currdate = new Date(setDate);
    var startingDate = new Date(currdate);
    var endingDate = new Date(currdate);
    var month;
    var date;
    var day;
    var column = 1;
    var headerCellClassName;
    var currentDateColumn = 16;
    var currentDateClass = 'CurrentDate';
    var headerCellsClass = 'headerCells';
    var holidayClass = 'Holiday';

    startingDate.setDate(startingDate.getDate() - 15);
    endingDate.setDate(endingDate.getDate() + 15);

    for (var pivot = startingDate; pivot <= endingDate; pivot.setDate(pivot.getDate() + 1)) {
        month = months[pivot.getMonth()];
        date = pivot.getDate();
        day = weekdays[pivot.getDay()];

        if (day == "Sat" || day == "Sun")
            headerCellClassName = headerCellsClass + holidayClass;
        else
            headerCellClassName = headerCellsClass;

        setCellAttributes("cell_0," + column, month, headerCellClassName);
        setCellAttributes("cell_1," + column, date, headerCellClassName);
        setCellAttributes("cell_2," + column, day, headerCellClassName);

        if (pivot.getDate() == currdate.getDate())
            currentDateColumn = column;

        column++;
    }

    if (currentDateColumn >= 0) {

        var headerClassName = document.getElementById("cell_0," + currentDateColumn).className + currentDateClass;
        setStyleToHeaderRowsByAColumn(currentDateColumn, headerClassName);

        //var leaveClassName = document.getElementById("cell_3," + currentDateColumn).className + currentDateClass;
        //setStyleToLeaveRowsByAColumn(currentDateColumn, leaveClassName);
    }
}

function setCellAttributes(id, text, classValue) {
    var cell = document.getElementById(id);
    cell.innerHTML = text;
    cell.className = classValue;
}

function setCellStyle(id, classValue) {
    var cell = document.getElementById(id);
    cell.className = classValue;
}

function setStyleToRowsRangeByAColumn(start, end, column, styleName) {
    for (var rowIndex = start; rowIndex <= end; rowIndex++) {
        setCellStyle("cell_" + rowIndex + "," + column, styleName);
    }
}

function setStyleToHeaderRowsByAColumn(column, styleName) {
    setStyleToRowsRangeByAColumn(0, 2, column, styleName);
}

function setStyleToLeaveRowsByAColumn(column, styleName) {
    setStyleToRowsRangeByAColumn(3, 13, column, styleName);
}

