$(function () {

    $("#NovaDijagnoza").validate(
        {
            rules: {
                Naziv: {
                    required: true
                },
                Opis:
                {
                    required: true
                }
            },
            messages:
            {
                Naziv: {
                    required: "Molimo unesite naziv dijagnoze!"
                },
                Opis: {
                    required: "Molimo unesite opis dijagnoze!"
                }
            }
        });
})