using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_create2DPlot : MonoBehaviour

{

    public List<Axis> perpendicularAxes { get; internal set; }

    [SerializeField]
    GameObject axisPrefab;

    [SerializeField]
    TextAsset pAxesSourceData;

    [SerializeField]
    DataObjectMetadata metadata;

    public DataBinding.DataObject dataObject;

    // Start is called before the first frame update
    void Start()
    {
        perpendicularAxes = new List<Axis>();
        dataObject = new DataBinding.DataObject(pAxesSourceData.text, metadata);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
