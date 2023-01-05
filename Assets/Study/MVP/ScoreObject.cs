using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace MVP
{
    public class ScoreObject : MonoBehaviour
    {
        Model _model = new();

        //ModelのScoreを参照できるようにする
        public IObservable<int> Score => _model.Score;

        private void OnDisable()
        {
            _model.Finished();
        }
    }
}
