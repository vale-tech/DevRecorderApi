db.auth('admin', 'password')

db = db.getSiblingDB('recorderOne')

db.createUser(
    {
        user: "user",
        pwd: "pass",
        roles: [
            {
                role: "readWrite",
                db: "recorderOne"
            }
        ]
    }
);

db = db.getSiblingDB('recorderTwo')

db.createUser(
    {
        user: "user",
        pwd: "pass",
        roles: [
            {
                role: "readWrite",
                db: "recorderTwo"
            }
        ]
    }
);
