//import { main } from "@popperjs/core";

var selectedSesija;
var selectedSesijaDiv = document.getElementById('selectedSesija');
var mainContainer = document.getElementById('mainContainerTermini');
var selectedTerminDiv = document.getElementById('selectedTermin');
var karticaContainer1 = document.getElementById("KarticaContainer1");
var karticaContainer2 = document.getElementById("KarticaContainer2");

var trmPocetak = document.getElementById('trmPocetak');
var trmKraj = document.getElementById('trmKraj');
var trmImePacijenta = document.getElementById('trmImePacijenta');
var trmUsluga = document.getElementById('trmUsluga');
var trmBasePrice = document.getElementById('trmBasePrice');

var s_trmPocetak = document.getElementById('s_trmPocetak');
var s_trmKraj = document.getElementById('s_trmKraj');
var s_trmImePacijenta = document.getElementById('s_trmImePacijenta');
var s_trmUsluga = document.getElementById('s_trmUsluga');
var s_trmBasePrice = document.getElementById('s_trmBasePrice');

var terminDate;


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
        initialView: 'listMonth',
        weekNumbers: true,
        dayMaxEvents: true, // allow "more" link when too many events

        dateClick: function (info) {
            info.dayEl.style.backgroundColor = 'red';
            console.log('day clicked' + info.date)
            calendar.changeView('timeGridDay', info.date)
        },

        hiddenDays: [0, 6],

        eventClick: function (info) {
            //alert('clicked on date ' + info.dateStr);
            console.log('isPrihvacen: ' + info.event.extendedProps.isPrihvacen);

            selectedSesija = {
                terminId: info.event.id,
                basePrice: info.event.extendedProps.basePrice,
                start: info.event.startStr,
                end: info.event.endStr,
                pacijent: info.event.extendedProps.pacijent,
                usluga: info.event.extendedProps.usluga,
                isPrihvacen: info.event.extendedProps.isPrihvacen
            }

            if (info.event.extendedProps.isPrihvacen) {
                //U konzoli atributi nisu poredani kao u kodu ispod
                //ali bitno je da imaju lmao

                selectedSesijaDiv.style.display = 'block';
                mainContainer.style.filter = "blur(4px)";
                karticaContainer1.style.display = 'block';
                //Empty text
                clearTerminDetails();

                //Initialize session
                fillTerminDetails(selectedSesija);


                console.log(selectedSesijaDiv);
                console.log(selectedSesija);
            }
            else {

                selectedTerminDiv.style.display = 'block';
                mainContainer.style.filter = "blur(4px)";
                karticaContainer2.style.display = 'block';

                s_clearTerminDetails();
                s_fillTerminDetails(selectedSesija);

                console.log('neprihvacen termin: ' + selectedSesija.isPrihvacen);
            }
        },

        eventDidMount: function (info) {
            $(info.el).tooltip({
                title: info.event.extendedProps.description,
                placement: "top",
                trigger: "hover",
                container: "body"
            });
        },
        eventSources: [
            {
                url: '/Termini/SFindAllPrihvaceni',
                color: '#00A8A8',
            },

            {
                url: '/Termini/SFindAllNePrihvaceni',
                color: 'red',
                textColor: 'red'
            }
        ],
        eventColor: '#00A8A8'
    });

    calendar.render();
});


function sendSesija() {
    //var URL = "../Sesija/Sesija?terminId=" + selectedSesija.terminId;
    //$.get(URL, function (d) {
    //    console.log('sendSesija: ');
    //})

    window.location.href = "/Sesija/Sesija?terminId=" + selectedSesija.terminId;
}

function odaberiTermin(TerminId) {
    var url = "/Termini/OdaberiTermin?t=" + TerminId;
    $.get(url, function (d) {
        $("#TerminOdabir").html(d);
    })
}

function clearTerminDetails() {
    trmPocetak.innerText = "";
    trmKraj.innerText = "";
    trmImePacijenta.innerText = "";
    trmUsluga.innerText = "";
    trmBasePrice.innerText = "";
}

function s_clearTerminDetails() {
    s_trmPocetak.innerText = "";
    s_trmKraj.innerText = "";
    s_trmImePacijenta.innerText = "";
    s_trmUsluga.innerText = "";
    s_trmBasePrice.innerText = "";
}


function fillTerminDetails(_selectedSesija) {
    var terminStartDate = new Date(_selectedSesija.start);   
    var terminEndDate = new Date(_selectedSesija.end);
    console.log('terminStartDate: ' + terminStartDate);
   
    trmPocetak.innerText += (terminStartDate.getUTCMonth() + 1) + '.' + terminStartDate.getUTCDate() + '.' + + terminStartDate.getUTCFullYear()
        + ' | ' + terminStartDate.getUTCHours() + ':' + (terminStartDate.getUTCMinutes() < 10 ? '0' : '') + terminStartDate.getUTCMinutes();

    trmKraj.innerText += (terminEndDate.getUTCMonth() + 1) + '.'
        + terminEndDate.getUTCDate() + '.' + 
        + terminEndDate.getUTCFullYear() + ' | '
        + terminEndDate.getUTCHours() + ':' + (terminEndDate.getUTCMinutes() < 10 ? '0' : '') + terminEndDate.getUTCMinutes();

    trmImePacijenta.innerText += _selectedSesija.pacijent.firstName + ' ' + _selectedSesija.pacijent.lastName;
    trmUsluga.innerText += _selectedSesija.usluga.naziv;
    trmBasePrice.innerText += _selectedSesija.basePrice;

}

function s_fillTerminDetails(_selectedSesija) {
    var terminStartDate = new Date(_selectedSesija.start);
    var terminEndDate = new Date(_selectedSesija.end);
    console.log('terminStartDate: ' + terminStartDate);

    s_trmPocetak.innerText += terminStartDate.getUTCDate() + '.'
        + (terminStartDate.getUTCMonth() + 1) + '.'
        + terminStartDate.getUTCFullYear() + ' | '
        + terminStartDate.getUTCHours() + ':' + (terminStartDate.getUTCMinutes() < 10 ? '0' : '') + terminStartDate.getUTCMinutes();

    s_trmKraj.innerText += terminEndDate.getUTCDate() + '.'
        + (terminEndDate.getUTCMonth() + 1) + '.'
        + terminEndDate.getUTCFullYear() + ' | '
        + terminEndDate.getUTCHours() + ':' + (terminEndDate.getUTCMinutes() < 10 ? '0' : '') + terminEndDate.getUTCMinutes();

    s_trmImePacijenta.innerText += _selectedSesija.pacijent.firstName + ' ' + _selectedSesija.pacijent.lastName;
    s_trmUsluga.innerText += _selectedSesija.usluga.naziv;
    s_trmBasePrice.innerText += _selectedSesija.basePrice;
}

function oznaciTermin(_oznaka) {
    $.ajax({
        type: 'POST',
        url: '/Termini/OznaciTermin',
        data: { oznaka: _oznaka, terminId: selectedSesija.terminId },

        success: function (data) {
            console.log('success: ' + data.responseText);
            window.location.reload();
        },

        error: function (data) {
            console.log('error: ' + data.responseText);
            alert('ajax error');
        },

        failure: function (data) {
            console.log('failure: ' + data.responseText);
            alert('ajax failure"');
        }
    })
}
