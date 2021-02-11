var dateClickedOn = false;
var selectedDayTermin;
var timePicker = document.getElementById('picker');

var selectedTermin = document.getElementById('selectedTermin');
var mainContainer = document.getElementById('calendar-pacijent');
var karticaContainer = document.getElementById("KarticaContainer");

var trmPocetak = document.getElementById('trmPocetak');
var trmImePacijenta = document.getElementById('trmImePacijenta');
var trmUsluga = document.getElementById('trmUsluga');
var trmBasePrice = document.getElementById('trmBasePrice');


var current = new Date();
var selectedDate = (current.getMonth() + 1) + '/' + current.getDate() + '/' + current.getFullYear();
var selectedTime;

var selectedHours;
var selectedDay;
var selectedMonth;
var selectedYear;

var dateOfTermin;

var cmbUsluge = document.getElementById('usluge');

var selectedUslugaId = document.getElementById('selectedUslugaId');

var fullSelectedDay;
var _selectedBasePrice;

//$(function () {
//    $("#picker").shieldTimePicker({        
//        events: {
//            change: function (e) {
//                selectedTime = timePicker.value;
//                console.log('selectedTime: ' + selectedTime)
//            }
//        }
//    });
//});



document.addEventListener('DOMContentLoaded', function () {
    var calendarEl = document.getElementById('calendar-pacijent');

    var calendar = new FullCalendar.Calendar(calendarEl, {
        timeZone: 'UTC',
        themeSystem: 'bootstrap',     
        headerToolbar: {
            left: 'prev,next today',
            center: 'title',
            right: 'dayGridMonth,timeGridWeek,timeGridDay,listMonth'
        },

        views: {
            dayGrid: { // name of view
                titleFormat: { year: 'numeric', month: 'long' },
                // other view-specific options here
            }
        },

        buttonIcons: true,
        weekNumbers: true,
        dayMaxEvents: true, // allow "more" link when too many events
        allDaySlot: false,
        slotMinTime: '08:00',
        slotMaxTime: '18:00',
        hiddenDays: [0, 6],
        dateClick: function (info) {
            //calendar.changeView('timeGridDay', info.date)

            //if (timePicker.value != 0 || timePicker.value != null) {
            //    selectedTime = timePicker.value;
            //} else {
            //    selectedTime = '8:00 AM';
            //}
            //saveTimePicker(); 
            //selectedTime = timePicker.value;
            
            if (!dateClickedOn) {
                info.dayEl.style.backgroundColor = '#00A8A8'
                dateClickedOn = true;
            }

            if (dateClickedOn && selectedDayTermin != null && selectedDayTermin != info.dayEl ) {
                selectedDayTermin.style.backgroundColor = '';
                info.dayEl.style.backgroundColor = '#00A8A8'
            }

            if (dateClickedOn && selectedDayTermin != null &&
                selectedDayTermin == info.dayEl) {
                calendar.changeView('timeGridDay', info.date)
            }

            selectedDayTermin = info.dayEl;
            selectedDate = info.date.getUTCFullYear() + '-'+(info.date.getUTCMonth() + 1) + '-' + info.date.getUTCDate();
            selectedDay = info.date.getDate();
            selectedMonth = info.date.getMonth() + 1;
            selectedYear = info.date.getFullYear();
            document.getElementById('datum').value = selectedDate;


            //setSelectedDate(info.date);

            validateDate();
        },        

        businessHours: {            
            daysOfWeek: [1, 2, 3, 4, 5], // Monday - Friday

            startTime: '08:00', 
            endTime: '17:00', 
        },

        events: '/Termini/PFindAll',
        eventColor: '#852828',
        locale: 'en-au'
    });

    calendar.render();
});


function showTerminDetails() {   
    selectedTermin.style.display = 'block';
    mainContainer.style.filter = 'blur(4px)';
    karticaContainer.style.display = 'block';

    if (timePicker.value != 0) {
        selectedTime = timePicker.value;
    } else {
        selectedTime = '8:00:00 AM';
    }

    dateOfTermin = selectedDate + ' ' + selectedTime;
    console.log(dateOfTermin);
    console.log('selectedTime: ' + selectedTime);

    //Empty details
    trmPocetak.innerText = '';
    trmUsluga.innerText = '';
    trmBasePrice.innerText = '';

    trmPocetak.innerText += dateOfTermin;
    trmUsluga.innerText += cmbUsluge.options[cmbUsluge.selectedIndex].innerText;
    selectedUslugaId = cmbUsluge.value;
    getCijenaUsluge(cmbUsluge.value);
}

function unSelectTermin() {
    selectedTermin.style.display = 'none';
    mainContainer.style.filter = 'blur(0px)';
    karticaContainer.style.display = 'none';
}

function getCijenaUsluge(_uslugaId) {
    $.ajax({
        type: 'GET',
        dataType: 'double',
        url: '/Termini/FindCijena',
        data: { uslugaId: _uslugaId },

        success: function (data) {
            console.log(data.responseText);
            trmBasePrice.innerText += data.responseText + ' KM';
            _selectedBasePrice = data.responseText;
        },

        error: function (data) {
            console.log(data.responseText);
            trmBasePrice.innerText += data.responseText + ' KM';
            _selectedBasePrice = data.responseText;
        },

        failure: function (data) {
            console.log(data.responseText);
            trmBasePrice.innerText += data.responseText + ' KM';
            _selectedBasePrice = data.responseText;
        }
        
    })
}

function validateDate() {
    var now = new Date();
    now.setHours(0, 0, 0, 0);

    var _selectedDate = new Date(selectedDate);   
    fullSelectedDay = selectedDate + ' ' + selectedTime;

    //console.log('selectedTime: ' + selectedTime);

    if (_selectedDate < now) {
        alert('Molimo izaberite validan datum');
    }
}

function zakaziTermin() {
    selectedHour = timePicker.value;
    //fullSelectedDay not good
    console.log('dateOfTermin: ' + dateOfTermin)
    fullSelectedDay = dateOfTermin

    $.ajax({
        type: 'POST',
        url: '/Termini/SpremiTermin/',
        data: { terminStart: fullSelectedDay, selectedBasePrice: _selectedBasePrice, _uslugaId: selectedUslugaId },

        success: function (data) {
            console.log(data.responseText);
            window.location.href = '/Termini/MojiTermini';
        },

        error: function (data) {
            console.log(data.responseText);
            window.location.href = '/Termini/MojiTermini';
        },

        failure: function (data) {
            console.log(data.responseText);
            window.location.href = '/Termini/MojiTermini';
        }
    })
}



timePicker.onchange = () => {
    console.log(timePicker.value);
}

function consoleLogTimePicker() {
    console.log(timePicker);
}