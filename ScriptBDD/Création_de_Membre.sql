OPEN SYMMETRIC KEY CleMembre DECRYPTION BY CERTIFICATE CertificatMembre;
 
INSERT INTO LP_Membre (nom, prenom, email, tel, login, password)
VALUES (
    ENCRYPTBYKEY(KEY_GUID('CleMembre'), 'Vivier-Merle'),
    ENCRYPTBYKEY(KEY_GUID('CleMembre'), 'Bastian'),
    ENCRYPTBYKEY(KEY_GUID('CleMembre'), 'bastian.viviermerle@example.com'),
    ENCRYPTBYKEY(KEY_GUID('CleMembre'), '0601020304'),
    ENCRYPTBYKEY(KEY_GUID('CleMembre'), 'bviviermerle'),
    CONVERT(CHAR(128), HASHBYTES('SHA2_512', 'B@stian07'), 2)
);
 
CLOSE SYMMETRIC KEY CleMembre;
 
DELETE FROM LP_Membre;