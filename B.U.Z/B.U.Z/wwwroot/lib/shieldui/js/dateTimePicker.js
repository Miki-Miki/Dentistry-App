var datum = document.getElementById('datum').value;

function destroyPicker() {
    $("#picker").swidget().destroy();
}

function enable() {
    $("#picker").swidget().enabled(true);
}

function disable() {
    $("#picker").swidget().enabled(false);
}

function show() {
    $("#picker").swidget().visible(true);
}

function hide() {
    $("#picker").swidget().visible(false);
}

function getSelected() {
    alert($("#picker").swidget().value());
}

function setSelectedDate(noviDatum) {
    $("#picker").swidget().value(noviDatum);
}

function showCalendar() {
    $("#picker").swidget().open("calendar");
}

function hideCalendar() {
    $("#picker").swidget().close("calendar");
}

function showCalendar1() {
    $("#picker").swidget().open("timeview");
}

function hideCalendar1() {
    $("#picker").swidget().close("timeview");
}
