$(function () {

    $("#NoviLijek").validate(
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
                    required: "Molimo unesite naziv lijeka!"
                },
                Opis: {
                    required: "Molimo unesite opis lijeka!"
                }
            }
        });
})