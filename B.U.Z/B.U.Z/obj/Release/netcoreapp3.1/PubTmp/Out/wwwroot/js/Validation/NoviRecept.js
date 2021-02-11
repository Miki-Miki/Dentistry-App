$(function () {

    $("#NoviRecept").validate(
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
                    required: "Molimo unesite naziv recepta!"
                },
                Opis: {
                    required: "Molimo unesite opis recepta!"
                }
            }
        });
})