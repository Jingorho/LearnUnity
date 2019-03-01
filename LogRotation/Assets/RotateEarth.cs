using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEarth : MonoBehaviour
{
    //回転軸として地軸の指定. z軸を傾けてるが田尻さんのプロジェクトに合わせて臨機応変に変えてください
    Vector3 axis_earth = Quaternion.Euler(0, 0, 23.4f) * Vector3.up; 
    //物理演算を行うための機能を使いますよ〜という意味
    Rigidbody rb;
    //角速度(angular velocity). 最初はなんでもいいけどテキトーに0ベクトル入れてる
    public Vector3 angVel = Vector3.zero;
    //角速度の大きさ(見た目としては、回転の速さ)を指定する値
    public float x = 10f;

    // Start is called before the first frame update
    void Start()
    {
        //物理演算を行うための機能を使うための準備
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //デバッグの残骸
        Debug.DrawLine(Vector3.zero, Vector3.up, Color.red);
        Debug.DrawLine(Vector3.zero, axis_earth, Color.green);
        //Debug.Log(angVel);

        //物理演算を行う機能のうち、Unityがあらかじめ準備してくれてる角速度を取り出す
        //しかも毎フレーム
        angVel = rb.angularVelocity;

        //Sキーを押した瞬間
        if(Input.GetKeyDown(KeyCode.S))
        {
            //地球にトルク(力のモーメント)を加える.
            rb.AddTorque(axis_earth * x);
            //https://ja.wikipedia.org/wiki/%E3%83%88%E3%83%AB%E3%82%AF
            //"トルク(力のモーメント) = 半径 * 力" だが、その結果が
            //"回転軸 * なんかの定数" となってるらしいので(Wikiの画像参照)、
            //"回転軸(この場合は地球の地軸) * 定数x" としている. 
            //Unityの公式ドキュメントとかもこういう書き方してる

            //Unityで回転というと下のような書き方が一般的だが、
            //「力を加えた」状態にしないと角速度が計測できなかった(ずっと0ベクトルだった)ので、ボツ
            //transform.Rotate(axis_earth, 60 * Time.deltaTime);
        }
        //Sキーを離した瞬間
        else if (Input.GetKeyUp(KeyCode.S))
        {
            //角速度に0ベクトルを代入して強制的に動きを止める
            rb.angularVelocity = Vector3.zero;
        }


        //Aキーを押した瞬間
        if (Input.GetKeyDown(KeyCode.A))
        {
            //定数にマイナスをかけて逆回転にしてる
            rb.AddTorque(axis_earth * (-1) * x);
            //transform.Rotate(axis_earth, -60 * Time.deltaTime);

        }
        //Aキーを離した瞬間
        else if (Input.GetKeyUp(KeyCode.A))
        {
            rb.angularVelocity = Vector3.zero;
        }




    }
}
