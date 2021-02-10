$(function () {

    $("#NoviPacijent").validate(
        {
            rules: {
                Ime: {
                    required: true
                },
                Prezime:
                {
                    required: true
                },
                DatumRodjenja:
                {
                    required: true
                },
                BrojTelefona:
                {
                    required: true
                },
                Email: {
                    required: true
                }
            },
            messages:
            {
                Ime: {
                    required: "Molimo unesite ime!"
                },
                Prezime: {
                    required: "Molimo unesite prezime!"
                },
                DatumRodjenja: {
                    required: "Molimo unesite validan datum rođenja!"
                },
                BrojTelefona:
                {
                    required: "Molimo unesite validan broj telefona!"
                },
                Email:
                {
                    required: "Molimo unesite validan email!"
                }

            }
        });
})