function CheckForm() {
    // checking username
    var uName = document.getElementById("uName").value;
    if (!userNameOK(uName))
        return false;
    // checking first name
    var fName = document.getElementById("fName").value;
    if (fName.length < 2) {
        document.ElementById("mfName").value = "user name does not exist or too short"
        document.getElementById("mFName").style.display = "inline";
        return false;
    }
    else
        document.getElementById("mFName").style.display = "none";

    /// checking last name
    var lName = document.getElementById("lName").value;
    if (lName.length < 2) {
        document.getElementById("mLname").value = "last name does not exist or too short"
        document.getElementById("mLName").style.display = "inline";
        return false;
    }
    else
        document.getElementById("mLName").style.display = "none";
    // checking Email
    var email = document.getElementById("email").value;
    emailOK(email)
    //// cheking the gender mark
    var gender = document.getElementByName("gender");
    if (chkRadioButton(gender)) {
        document.getElementById("mGender").value = "must select gender"
        document.getElementById("mGender").style.display = "inline";
        return false;
    }
    else
        document.getElementById("mGender").style.display = "none";
    /// cheking phone number
    var phone = document.getElementById("phoneNum").value;
    if (phone.length != 7) {
        document.getElementById("mPhone").value = "phone number must contain 7 numbers ";
        document.getElementById("mPhone").style.display = "inline";
        return false;
    }
    else document.getElementById("mPhone").style.display = "none";
    if (isNaN(phone)) {
        document.getElementById("mPhone").value = "phone number must contain numbers only"
        document.getElementById("mPhone").style.display = "inline";
        return false;
    }
    else
        document.getElementById("mPhone").style.display = "none";
    ////Place of residence
    var city = document.getElementById("city").value;
    if (city == "other") {
        msg = "must chosse the Place of residence ";
        document.getElementById("mCity").value = msg;
        document.getElementById("mCity").style.display = "inline";
        msg = "";
        return false;
    }
    else
        document.getElementById("mCity").style.display = "none";
    /// hobies
    var hobies = document.getElementsByName("hobies");
    var hobChecked = false;
    for (var i = 0; i < hobies.length; i++)
        if (hobies[i].checked) hobChecked = true;
    if (hobChecked == false) {
        document.getElementById("mHobies").value = "should chosse a hobie"
        document.getElementById("mHobies").style.display = "inline";
        return false;
    }
    else document.getElementById("mHobies").style.display = "none";
    /// checking password
    var pw = document.getElementById("password").value;
    var pw1 = document.getElementById("rePassword").value;
    if (pw.length < 6 || pw.length > 8) {
        msg = " password must contain 6-8 chars";
        document.getElementById("mPassword").value = msg;
        document.getElementById("mPassword").style.display = "inline";
        return false;
    }
    else
        document.getElementById("mPassword").style.display = "none";
    /// checking if the inserted password similar to the other password
    if (pw != pw1) {
        msg = "the passwords are not simmilar to each other"
        document.getElementById("mPassword").value = msg;
        document.getElementById("mPassword").style.display = "inline";
        msg = "";
        return false;
    }
    return true;
}
/// diffirent things to check
function userNameOK(name) {
    var msg = "";
    if (name.length < 6)
        msg = "user name does not exist or too short"
    else if (name.length > 30)
        msg = "user name must have 6-30 letters"
    else if (isHebrew(name))
        msg = "user name can not be in hebrew";
    else if (isQuot(name))
        msg = "user name must not have chars like Punctuation";
    else if (isBadChars(name))
        msg = "user name must be only in english and in letters";
    if (msg != "") {
        document.getElementById("mUName").value = msg;
        document.getElementById("mUName").style.display = "inline";
        return false;
    }
    else
        document.getElementById("mUName").style.display = "none";
    return true;
}
function emailOK(mail) {
    var msg = "";
    var atSign = mail.indexOf('@');
    var dotSign = mail.indexOf('.', atSign);
    //alert("dot place = " + dotSign + "\n @ place = " + atSign);
    // checking lenght or forbidden chars
    if (mail.length < 6)
        msg = "Email is too short or dose not exist";
    else if (mail.length > 30)
        msg = "Email can not contain letters from Hebrew";
    else if (isQuot(mail) || isBadChars(mail))
        msg = "Email dose include forbidden chars"
    else if (atSign == -1 || atSign != mail.lastIndexOf('@'))
        msg = "Email must contain only one @"
    else if (dotSign == -1)
        msg = "Email must have one dote/full stop. after the @ "
    else if (dotSign - atSign < 2)
        msg = "the full stop{.} must come after two letters after the @";
    else if (dotSign == mail.length - 1 || mail.indexOf('.') == 0)
        msg = "the full stop{.} can not appear in the begining and the ending of the sentince";
    msg = "the @ can not appear in the begining and the ending of the sentince";
    /// if there is no problem
    if (msg != "") {
        document.getElementById("mEmail").value = msg;
        document.getElementById("mEmail").style.display = "inline";
        return false;
    }
    else
        document.getElementById("mEmail").style.display = "none";
    /// if there is a forbidden char like {''}
    function isQuot(str) {
        var quot = '\"', quot1 = "\'";
        if (str.indexOf(quot) != -1 || str.indexOf(quot1) != -1)
            return true;
        return false;
    }
    /// contains forbidden chars like:"$%^&*()-! []{}<>?
    function isBadChars(str) {
        var badChr = "$%^&*()-! []{}<>?";
        var len = badChr.length;
        var i = 0, pos, ch;
        while (i < len) {
            ch = badChr.charAt(i);
            pos = str.indexOf(ch);
            if (pos != -1)
                return true;
            i++;
        }
        return false;
    }
    /// letters in hebrew
    function isHebrew(str) {
        for (var i = 0; i < str.length; i++) {
            if (str.charAt(i) >= 'א'(str.charAt(i) <= 'ת'))

                return true;
        }

    }
    return false;
}

///a funcion that chech if the alredy selected options 
function chkRadioButton(gender) {
    if (!gender[0].checked && gender[1].checked == false)
        return false;
    return true;
}
/// checking the borning year 
function yearBornOk(year) {
    var msg = "";
    var d = new Date();
    var current = d.getFullYear();
    //alert("current year = " + current);
    var old = current - 100;
    var young = current - 5;
    if (isNaN(year))          // isNaN = is Not a Number
        msg = "the birth year must only contain numbers";
    else if (year < 1900)
        msg = "the birth must contain 4 numbers i mean you are not a propet or something ";
    else if (year < old)
        msg = "too old you pice of ** birth year must be bigger than" + (old - 1);
    else if (year >= young)
        msg = " too young boy go play outside birth year must be lesser than" + young;
    if (msg != "") {
        document.getElementById("mYearBorn").value = msg;
        document.getElementById("mYearBorn").style.display = "inline";
        return false;
    }
    else
        document.getElementById("mYearBorn").style.display = "none";
    return true;
}