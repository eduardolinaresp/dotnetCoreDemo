upstream myapp {
 server appx:5000;
}


server{

  listen 80;
  server_name example.com;

  proxy_read_timeout 720s;
  proxy_connect_timeout 720s;
  proxy_send_timeout 720s;

    # Proxy headers
  proxy_set_header X-Forwarded-Host $host;
  proxy_set_header X-Forwarded-For $proxy_add_x_forwarded_for;
  proxy_set_header X-Forwarded-Proto $scheme;
  proxy_set_header X-Real-IP $remote_addr;

   location / {
       proxy_redirect off;
       proxy_pass http://myapp;
 }

}