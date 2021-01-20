var dateClickedOn = false;
var selectedDayTermin;
var timePicker = document.getElementById('picker');

var selectedTermin = document.getElementById('selectedTermin');
var mainContainer = document.getElementById('kontejner');

var trmPocetak = document.getElementById('trmPocetak');
var trmImePacijenta = document.getElementById('trmImePacijenta');
var trmUsluga = document.getElementById('trmUsluga');
var trmBasePrice = document.getElementById('trmBasePrice');


var current = new Date();
var selectedDay = (current.getMonth() + 1) + '/' + current.getDate() + '/' + current.getFullYear();;
var selectedTime;

var dateOfTermin;

var cmbUsluge = document.getElementById('usluge');

var selectedUslugaId = document.getElementById('selectedUslugaId');

document.addEventListener('DOMContentLoaded', function () {
    var calendarEl = document.getElementById('calendar-pacijent');

    var calendar = new FullCalendar.Calendar(calendarEl, {
        timeZone: 'local',
        themeSystem: 'bootstrap',
        locale: 'bs',       
        headerToolbar: {
            left: 'prev,next today',
            center: 'title',
            right: 'dayGridMonth,timeGridWeek,timeGridDay,listMonth'
        },
        weekNumbers: true,
        dayMaxEvents: true, // allow "more" link when too many events
        allDaySlot: false,
        slotMinTime: '08:00',
        slotMaxTime: '18:00',
        dateClick: function (info) {
            //calendar.changeView('timeGridDay', info.date)

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
            selectedDay = (info.date.getMonth() + 1) + '/' + info.date.getDate() + '/' + info.date.getFullYear();
            document.getElementById('datum').value = selectedDay;
            //setSelectedDate(info.date);
        },

        //eventDidMount: function (info) {
        //    $(info.el).tooltip({
        //        title: 'Zauzeto',
        //        placement: "top",
        //        trigger: "hover",
        //        container: "body"
        //    });
        //},

        businessHours: {            
            daysOfWeek: [1, 2, 3, 4, 5], // Monday - Friday

            startTime: '08:00', 
            endTime: '17:00', 
        },

        events: '/Termini/PFindAll',
        eventColor: '#852828'
    });

    calendar.render();
});


function showTerminDetails() {   
    selectedTermin.style.display = 'block';
    mainContainer.style.filter = 'blur(4px)';

    if (timePicker.value != 0) {
        selectedTime = timePicker.value;
        console.log('timePicker != null ;' + selectedTime)
    } else {
        selectedTime = '8:00 AM';
        console.log('timePicker == null ;' + selectedTime)
    }
    dateOfTermin = selectedDay + ' ' + selectedTime;
    console.log(dateOfTermin);

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
        },

        error: function (data) {
            console.log(data.responseText);
            trmBasePrice.innerText += data.responseText + ' KM';
        },

        failure: function (data) {
            console.log(data.responseText);
            trmBasePrice.innerText += data.responseText + ' KM';
        }
        
    })
}