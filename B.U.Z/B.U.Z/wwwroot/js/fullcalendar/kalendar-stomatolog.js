//import { main } from "@popperjs/core";

var selectedSesija;
var selectedSesijaDiv = document.getElementById('selectedSesija');
var mainContainer = document.getElementById('mainContainerTermini');
var selectedTerminDiv = document.getElementById('selectedTermin');

var trmPocetak = document.getElementById('trmPocetak');
var trmKraj = document.getElementById('trmKraj');
var trmImePacijenta = document.getElementById('trmImePacijenta');
var trmUsluga = document.getElementById('trmUsluga');
var trmBasePrice = document.getElementById('trmBasePrice');

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

                ////Empty text
                //trmPocetak.innerText = "";
                //trmKraj.innerText = "";
                //trmImePacijenta.innerText = "";
                //trmUsluga.innerText = "";
                //trmBasePrice.innerText = "";

                ////Initialize session
                //trmPocetak.innerText += selectedSesija.start;
                //trmKraj.innerText += selectedSesija.end;
                //trmImePacijenta.innerText += selectedSesija.pacijent.firstName + ' ' + selectedSesija.pacijent.lastName;
                //trmUsluga.innerText += selectedSesija.usluga.naziv;
                //trmBasePrice.innerText += selectedSesija.basePrice;
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

//terminId: info.event.id,
//    basePrice: info.event.extendedProps.basePrice,
//        start: info.event.startStr,
//            end: info.event.endStr,
//                pacijent: info.event.extendedProps.pacijent,
//                    usluga: info.event.extendedProps.usluga,
//                        isPrihvacen: info.event.extendedProps.isPrihvacen

function fillTerminDetails(_selectedSesija) {
    var terminStartDate = new Date(_selectedSesija.start);    
    console.log('terminStartDate: ' + terminStartDate);

    trmPocetak.innerText += terminStartDate.getDate() + '.' + (terminStartDate.getMonth() + 1) + '.' + terminStartDate.getFullYear() + ' | ';
    trmKraj.innerText += _selectedSesija.end;
    trmImePacijenta.innerText += _selectedSesija.pacijent.firstName + ' ' + _selectedSesija.pacijent.lastName;
    trmUsluga.innerText += _selectedSesija.usluga.naziv;
    trmBasePrice.innerText += _selectedSesija.basePrice;

}
