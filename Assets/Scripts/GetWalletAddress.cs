using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
// use web3.jslib
using System.Runtime.InteropServices;

public class GetWalletAddress : MonoBehaviour
{
    // text in the button
    public TMP_Text _walletID;
    [SerializeField]
    Button _button;
    // use WalletAddress function from web3.jslib
    [DllImport("__Internal")] private static extern string WalletAddress();

    //void Awake() => _button.onClick.AddListener(OnClick);
    
    public void OnClick()
    {
        // get wallet address and display it on the button
        _walletID.text = WalletAddress();
    }
}