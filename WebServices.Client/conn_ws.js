var conn = new WebSocket('wss://monsite.com/ws/monappli');
conn.onopen = function(e) {
    console.log("Connection established!");
    conn.send('Hello World');
};

conn.onmessage = function(e) {
    console.log(e.data);
};