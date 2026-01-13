using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public enum Reviewer
{
    GNI, 
    Betascoric, 
    Gamespotter, 
    CMPRag, 
    Ukotak
}

public class MultipleReviewer : MonoBehaviour
{
    public Reviewer reviewer;

    public List<Reviewer> reviwerList = new List<Reviewer>();
}
