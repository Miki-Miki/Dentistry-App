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
        eventDidMount: function (info) {
            $(info.el).tooltip({
                title: 'Zauzeto',
                placement: "top",
                trigger: "hover",
                container: "body"
            });
        },
        events: '/Termini/PFindAll',
        eventColor: '#cc2d2d',
    });

    calendar.render();
});