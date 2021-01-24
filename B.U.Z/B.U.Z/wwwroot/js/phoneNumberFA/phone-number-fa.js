let codeInput = document.getElementById('phoneAuthCode');
let phoneFACode = document.getElementById('phoneFACode');
let phoneNumberInput = document.getElementById('phoneNumber');
codeInput.disabled = true;

let _code;
let _phoneNumber = '+387644019453';

function generateCode() {
    _code = Math.floor(1000 + Math.random() * 9000);
    phoneFACode.value = _code;
    phoneNumberInput.value = _phoneNumber;
}

generateCode();