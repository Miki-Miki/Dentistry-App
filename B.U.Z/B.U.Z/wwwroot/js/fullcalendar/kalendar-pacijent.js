document.addEventListener('DOMContentLoaded', function () {
    var calendarEl = document.getElementById('calendar-pacijent');

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
        dateClick: function (info) {
            console.log('day clicked' + info.date)
            calendar.changeView('timeGridDay', info.date)
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