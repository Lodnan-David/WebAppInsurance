function restrictInputToNumbers(input) {
    input.value = input.value.replace(/\D/g, '');
}
// Validace pole vstupu pro mobilní číslo
const PhoneInput = document.getElementById('Phone-input');
PhoneInput.addEventListener('input', function (event) {
    const value = event.target.value;
    const isValid = /^\+?[0-9]+$/.test(value);
    event.target.setCustomValidity(isValid ? '' : 'Prosím, zadejte platné mobilní číslo.');
});
