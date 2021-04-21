using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class connect : MonoBehaviour
{

    MongoClient client = new MongoClient("");//Client


    // Start is called before the first frame update
    void Start()
    {
        IMongoDatabase db = client.GetDatabase("");//DatabaseName
        var collection = db.GetCollection<BsonDocument>("");//CollectorName
        var doc = new BsonDocument
            {
                {"name", "Mercedes"},
                {"price", 28563}
            };

        collection.InsertOne(doc);//Insert
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
