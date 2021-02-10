$(function () {

    $("#NovoDentalnoPomagalo").validate(
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
                    required: "Molimo unesite naziv dentalnog pomagala!"
                },
                Opis: {
                    required: "Molimo unesite opis dentalnog pomagala!"
                }
            }
        });
})