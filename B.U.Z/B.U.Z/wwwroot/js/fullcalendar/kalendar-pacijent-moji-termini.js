var dateClickedOn = false;
var selectedDayTermin;

document.addEventListener('DOMContentLoaded', function () {
    var calendarEl = document.getElementById('calendar-pacijent-moji-termini');

    var calendar = new FullCalendar.Calendar(calendarEl, {
        timeZone: 'UTC',
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
        hiddenDays: [0, 6],
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
            document.getElementById('datum').value = info.date
            setSelectedDate(info.date);
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

        events: '/Termini/FindAllMojiTermini',
        eventColor: '#0062cc'
    });

    calendar.render();
});

