let privateKey, encryptedString, algoType = "Rsa";

document.getElementById("algo-select").addEventListener('change', ({ target }) => {
    algoType = target.value;
    console.log(algoType);
})

document.getElementById('private-key').addEventListener('change', ({ target }) => {
    const reader = new FileReader();
    reader.readAsText(target.files[0]);
    reader.onloadend = async () => {
        const xml = htmlDecode(String(reader.result));

        privateKey = {
            Modulus: getXmlNode(xml, 'Modulus'),
            Exponent: getXmlNode(xml, 'Exponent'),
            P: getXmlNode(xml, 'P'),
            Q: getXmlNode(xml, 'Q'),
            DP: getXmlNode(xml, 'DP'),
            DQ: getXmlNode(xml, 'DQ'),
            InverseQ: getXmlNode(xml, 'InverseQ'),
            D: getXmlNode(xml, 'D')
        }
        document.getElementById('txt').disabled = false;
    };
});

document.getElementById('txt').addEventListener('change', ({ target }) => {
    const reader = new FileReader();
    reader.readAsText(target.files[0]);
    reader.onloadend = async () => {
        encryptedString = String(reader.result);
        document.getElementById('btn-decrypt').disabled = false;
    };
})

document.getElementById('btn-decrypt').addEventListener('click', async () => {
    const div = document.getElementById("decrypted");

    div.innerHTML = await decryptRequest("/api/Rsa", {
        privateKey,
        encryptedString
    });
    div.removeAttribute("hidden");



    document.getElementById('btn-decrypt').disabled = true;
    document.getElementById('txt').value = "";
    document.getElementById('txt').disabled = true;
    document.getElementById('private-key').value = "";
})

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