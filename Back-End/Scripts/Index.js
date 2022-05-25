let privateKey, encryptedString, algoType;

document.getElementById("algo-select").addEventListener('change', ({ target }) => {
    algoType = target.value;
    document.getElementById("private-key").disabled = false;
})

function decryptGetPrivateKey({target}) {
    const reader = new FileReader();
    reader.readAsText(target.files[0]);
    reader.onloadend = async () => {
        const xml = htmlDecode(String(reader.result));

        switch (algoType) {
            case "Rsa":
                privateKey = getXmlNode(xml, "clavePrivada");
                break;
            case "ECDiffiehellman":
                privateKey = {
                    IV: getXmlNode(xml, 'IV'),
                    Key: getXmlNode(xml, 'Key')
                };
                break;
            default:
                break;
        }

        document.getElementById("private-key-text").value = privateKey;
        document.getElementById('txt').disabled = false;
    };
}

function decryptGetTxt({ target }) {
    const reader = new FileReader();
    reader.readAsText(target.files[0]);
    reader.onloadend = async () => {
        encryptedString = String(reader.result);
        document.getElementById('btn-decrypt').disabled = false;
        document.getElementById("txt-text").value = encryptedString;
    };
}

async function decrypt() {
    const div = document.getElementById("decrypted");

    div.innerHTML = await decryptRequest(`/api/${algoType}/Decrypt`, {
        privateKey,
        encryptedString
    });
    div.removeAttribute("hidden");
    document.getElementById('btn-decrypt').disabled = true;
    document.getElementById('txt').value = "";
    document.getElementById('txt').disabled = true;
    document.getElementById('private-key').value = "";
}

function htmlDecode(input) {
    const e = document.createElement('textarea');
    e.innerHTML = input;
    return e.childNodes.length === 0 ? "" : e.childNodes[0].nodeValue;
}

function getXmlNode(xml, nodeName) {
    return xml.split("<" + nodeName + ">")[1].split("</" + nodeName + ">")[0];
}

async function decryptRequest(url, data) {
    const config = {
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        method: "POST",
        body: JSON.stringify(data)
    };
    return await (await fetch(url, config)).json();
}