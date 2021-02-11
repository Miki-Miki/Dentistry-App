$(document).ready(function () {
    var trenutnaLokacija = window.location.pathname;
    if (trenutnaLokacija == "/Pacijenti/Pacijenti" || trenutnaLokacija == "/Pacijenti/NoviPacijent") {
        document.getElementById("ListPacijent").style.backgroundColor = "#0C6980";
        if (trenutnaLokacija == "/Pacijenti/Pacijenti") {

            $(".PostojeciPacijenti").attr("style", "background-color:#0C6980 !important");
        }
        else {
            $(".DodajNovogPacijenta").attr("style", "background-color:#0C6980 !important");
        }
    }
    else if (trenutnaLokacija == "/Termini/Termini" || trenutnaLokacija == "/Termini/Kalendar" || trenutnaLokacija == "/Termini/NoviTermin") {
        document.getElementById("ListTermin").style.backgroundColor = "#0C6980";

        if (trenutnaLokacija == "/Termini/Termini" || trenutnaLokacija =="/Termini/Kalendar") {

            $(".AktivniTermini").attr("style", "background-color:#0C6980 !important");
        }
        else {
            $(".DodajNoviTermin").attr("style", "background-color:#0C6980 !important");
        }
    }
    else if (trenutnaLokacija == "/Obavijesti/Obavijesti") {
        document.getElementById("ListObavijest").style.backgroundColor = "#0C6980";
    }
    else if (trenutnaLokacija == "/Dijagnoze/Dijagnoze" || trenutnaLokacija == "/Dijagnoze/NovaDijagnoza") {
        document.getElementById("ListDijagnoza").style.backgroundColor = "#0C6980";

        if (trenutnaLokacija == "/Dijagnoze/Dijagnoze") {
            $(".PostojeceDijagnoze").attr("style", "background-color:#0C6980 !important");
        }
        else {
            $(".DodajNovuDijagnozu").attr("style", "background-color:#0C6980 !important");
        }
    }
    else if (trenutnaLokacija == "/Recepti/Recepti" || trenutnaLokacija == "/Recepti/NoviRecept") {
        document.getElementById("ListRecept").style.backgroundColor = "#0C6980";
        if (trenutnaLokacija == "/Recepti/Recepti") {
            $(".PostojeciRecepti").attr("style", "background-color:#0C6980 !important");
        }
        else {
            $(".DodajNoviRecept").attr("style", "background-color:#0C6980 !important");
        }
    }
    else if (trenutnaLokacija == "/Lijekovi/Lijekovi" || trenutnaLokacija == "/Lijekovi/NoviLijek") {
        document.getElementById("ListLijek").style.backgroundColor = "#0C6980";
        if (trenutnaLokacija == "/Lijekovi/Lijekovi") {
            $(".PostojeciLijekovi").attr("style", "background-color:#0C6980 !important");
        }
        else {
            $(".DodajNoviLijek").attr("style", "background-color:#0C6980 !important");
        }
    }
    else if (trenutnaLokacija == "/DentalnaPomagala/DentalnaPomagala" || trenutnaLokacija == "/DentalnaPomagala/NovoDentalnoPomagalo") {
        document.getElementById("ListDentalnoPomagalo").style.backgroundColor = "#0C6980";
        if (trenutnaLokacija == "/DentalnaPomagala/DentalnaPomagala") {
            $(".PDP").attr("style", "background-color:#0C6980 !important");
        }
        else {
            $(".DNDP").attr("style", "background-color:#0C6980 !important");
        }
    }
    else if (trenutnaLokacija == "/UserAccounts/UserAccounts" || trenutnaLokacija == "/UserAccounts/NoviUserAccountStomatolog" || trenutnaLokacija=="/UserAccounts/NoviUserAccountAsistent") {
        document.getElementById("ListUserAccount").style.backgroundColor = "#0C6980";
        if (trenutnaLokacija == "/UserAccounts/UserAccounts") {
            $(".PU").attr("style", "background-color:#0C6980 !important");
        }
        else if (trenutnaLokacija == "/UserAccounts/NoviUserAccountStomatolog") {
            $(".DS").attr("style", "background-color:#0C6980 !important");
        }
        else {
            $(".DA").attr("style", "background-color:#0C6980 !important");
        }
    }
    else if (trenutnaLokacija == "/Termini/MojiTermini") {
        document.getElementById("MojiTermini").style.backgroundColor = "#0C6980";
    }
    else if (trenutnaLokacija == "/Pacijenti/KartonPacijenta") {
        document.getElementById("Karton").style.backgroundColor = "#0C6980";
    }
    
});
