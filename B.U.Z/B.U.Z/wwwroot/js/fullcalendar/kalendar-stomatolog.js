//import { main } from "@popperjs/core";

var selectedSesija;
var selectedSesijaDiv = document.getElementById('selectedSesija');
var mainContainer = document.getElementById('mainContainerTermini');

var trmPocetak = document.getElementById('trmPocetak');
var trmKraj = document.getElementById('trmKraj');
var trmImePacijenta = document.getElementById('trmImePacijenta');
var trmUsluga = document.getElementById('trmUsluga');
var trmBasePrice = document.getElementById('trmBasePrice');

document.addEventListener('DOMContentLoaded', function () {
    var calendarEl = document.getElementById('calendar-stomatolog');

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

        eventClick: function (info) {
            //alert('clicked on date ' + info.dateStr);
            console.log('clicked on event ' + info);

            //U konzoli atributi nisu poredani kao u kodu ispod
            //ali bitno je da imaju lmao
            selectedSesija = {
                terminId: info.event.id,
                basePrice: info.event.extendedProps.basePrice,
                start: info.event.startStr,
                end: info.event.endStr,
                pacijent: info.event.extendedProps.pacijent,
                usluga: info.event.extendedProps.usluga
            }

            selectedSesijaDiv.style.display = 'block';
            mainContainer.style.filter = "blur(4px)";

            //Empty text
            trmPocetak.innerText = "";
            trmKraj.innerText = "";
            trmImePacijenta.innerText = "";
            trmUsluga.innerText = "";
            trmBasePrice.innerText = "";

            //Initialize session
            trmPocetak.innerText += selectedSesija.start;
            trmKraj.innerText += selectedSesija.end;
            trmImePacijenta.innerText += selectedSesija.pacijent.firstName + ' ' + selectedSesija.pacijent.lastName;
            trmUsluga.innerText += selectedSesija.usluga.naziv;
            trmBasePrice.innerText += selectedSesija.basePrice;


            console.log(selectedSesijaDiv);
            console.log(selectedSesija);
        },

        eventDidMount: function (info) {
            $(info.el).tooltip({
                title: info.event.extendedProps.description,
                placement: "top",
                trigger: "hover",
                container: "body"
            });
        },
        events: '/Termini/SFindAll'
    });

    calendar.render();
});


function sendSesija() {
    //var URL = "../Sesija/Sesija?terminId=" + selectedSesija.terminId;
    //$.get(URL, function (d) {
    //    console.log('sendSesija: ');
    //})

    $.ajax({
        type: "POST",
        url: "/Sesija/Sesija",
        data: { terminId: selectedSesija.terminId },

        success: function (data) {
            window.location.href = "/Sesija/Sesija?terminId=" + selectedSesija.terminId;
        },

        error: function (data) {
            window.location.href = "/Sesija/Sesija?terminId=" + selectedSesija.terminId;
        },

        failure: function (data) {
            window.location.href = "/Sesija/Sesija";
        },
    });

}

function odaberiTermin(TerminId) {
    var url = "/Termini/OdaberiTermin?t=" + TerminId;
    $.get(url, function (d) {
        $("#TerminOdabir").html(d);
    })
}