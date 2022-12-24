function convertFirstLetterToUpperCase(text) {
    return text.charAt(0).toUpperCase() + text.slice(1);
}
/* indexdeki harfi almamızı sağlıyor. ilk harfi büyük olacak.  */

/*  js tarih formatı */
function convertToShortDate(dateString) {
    const shortDate = new Date(dateString).toLocaleDateString('en-US');
    return shortDate;
}

