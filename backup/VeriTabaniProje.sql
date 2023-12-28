CREATE DATABASE "VeriTabaniProje"
    WITH
    OWNER = postgres
    ENCODING = 'UTF8'
    LC_COLLATE = 'Turkish_T rkiye.1254'
    LC_CTYPE = 'Turkish_T rkiye.1254'
    LOCALE_PROVIDER = 'libc'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1
    IS_TEMPLATE = False;

CREATE TABLE IF NOT EXISTS public.antrenor
(
    kisi_id integer NOT NULL,
    takim_id integer,
    CONSTRAINT antrenorfk PRIMARY KEY (kisi_id),
    CONSTRAINT antrenorkisi FOREIGN KEY (kisi_id)
        REFERENCES public.kisi (kisi_id) MATCH SIMPLE
        ON UPDATE CASCADE
        ON DELETE CASCADE,
    CONSTRAINT antrenortakimfk FOREIGN KEY (takim_id)
        REFERENCES public.takim (takim_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.antrenor
    OWNER to postgres;

CREATE TABLE IF NOT EXISTS public.futbolcu
(
    kisi_id integer NOT NULL,
    takim_id integer,
    mevki_id integer,
    CONSTRAINT futbolcufk PRIMARY KEY (kisi_id),
    CONSTRAINT futbolcukisi FOREIGN KEY (kisi_id)
        REFERENCES public.kisi (kisi_id) MATCH SIMPLE
        ON UPDATE CASCADE
        ON DELETE CASCADE,
    CONSTRAINT futbolcumevkifk FOREIGN KEY (mevki_id)
        REFERENCES public.mevki (mevki_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT futbolcutakimfk FOREIGN KEY (takim_id)
        REFERENCES public.takim (takim_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.futbolcu
    OWNER to postgres;

CREATE TABLE IF NOT EXISTS public.hakem
(
    kisi_id integer NOT NULL,
    CONSTRAINT hakempk PRIMARY KEY (kisi_id),
    CONSTRAINT hakemkisi FOREIGN KEY (kisi_id)
        REFERENCES public.kisi (kisi_id) MATCH SIMPLE
        ON UPDATE CASCADE
        ON DELETE CASCADE
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.hakem
    OWNER to postgres;
CREATE TABLE IF NOT EXISTS public.iletisimbilgileri
(
    no integer NOT NULL,
    telno character varying(10) COLLATE pg_catalog."default",
    ulke integer NOT NULL,
    kisi_id integer NOT NULL DEFAULT nextval('iletisimbilgileri_kisi_id_seq'::regclass),
    CONSTRAINT iletisimbilgileri_pkey PRIMARY KEY (no),
    CONSTRAINT iletisim_ulkefk FOREIGN KEY (ulke)
        REFERENCES public.ulke (ulke_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.iletisimbilgileri
    OWNER to postgres;
-- Index: fki_iletisim_ulkefk

-- DROP INDEX IF EXISTS public.fki_iletisim_ulkefk;

CREATE INDEX IF NOT EXISTS fki_iletisim_ulkefk
    ON public.iletisimbilgileri USING btree
    (ulke ASC NULLS LAST)
    TABLESPACE pg_default;

CREATE TABLE IF NOT EXISTS public.kisi
(
    kisi_id integer NOT NULL,
    kisi_ad character varying(40) COLLATE pg_catalog."default" NOT NULL,
    kisi_soyad character varying(40) COLLATE pg_catalog."default" NOT NULL,
    olcu_id integer,
    CONSTRAINT kisipk PRIMARY KEY (kisi_id),
    CONSTRAINT kisi_olcuidfk FOREIGN KEY (olcu_id)
        REFERENCES public.vucutolculeri (olcu_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.kisi
    OWNER to postgres;

CREATE TABLE IF NOT EXISTS public.lig
(
    lig_id integer NOT NULL,
    lig_adi character varying(40) COLLATE pg_catalog."default",
    CONSTRAINT lig_pkey PRIMARY KEY (lig_id)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.lig
    OWNER to postgres;

CREATE TABLE IF NOT EXISTS public.mac
(
    mac_id integer NOT NULL,
    CONSTRAINT mac_pkey PRIMARY KEY (mac_id)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.mac
    OWNER to postgres;

CREATE TABLE IF NOT EXISTS public.machakemleri
(
    hakem_id integer NOT NULL,
    mac_id integer NOT NULL,
    CONSTRAINT machakemleri_pk PRIMARY KEY (hakem_id, mac_id),
    CONSTRAINT fkhakem FOREIGN KEY (hakem_id)
        REFERENCES public.hakem (kisi_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fkmac FOREIGN KEY (mac_id)
        REFERENCES public.mac (mac_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.machakemleri
    OWNER to postgres;

CREATE TABLE IF NOT EXISTS public.macstadyumlari
(
    stadyum_id integer NOT NULL,
    mac_id integer NOT NULL,
    CONSTRAINT macstadyumlari_pkey PRIMARY KEY (stadyum_id, mac_id),
    CONSTRAINT macidfk FOREIGN KEY (mac_id)
        REFERENCES public.mac (mac_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID,
    CONSTRAINT stadyumidfk FOREIGN KEY (stadyum_id)
        REFERENCES public.stadyum (stadyum_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.macstadyumlari
    OWNER to postgres;

CREATE TABLE IF NOT EXISTS public.mactakimleri
(
    mac_id integer NOT NULL,
    takim_id integer NOT NULL,
    CONSTRAINT mactakimleri_pkey PRIMARY KEY (mac_id, takim_id),
    CONSTRAINT macid_fk FOREIGN KEY (mac_id)
        REFERENCES public.mac (mac_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID,
    CONSTRAINT takimid_fk FOREIGN KEY (takim_id)
        REFERENCES public.takim (takim_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.mactakimleri
    OWNER to postgres;

CREATE TABLE IF NOT EXISTS public.mevki
(
    mevki_id integer NOT NULL,
    mevki_ad character varying(40) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT mevki_pkey PRIMARY KEY (mevki_id)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.mevki
    OWNER to postgres;

CREATE TABLE IF NOT EXISTS public.silinenfutbolcular
(
    skisi_id integer,
    skisi_takimid integer,
    skisi_mevkiid integer
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.silinenfutbolcular
    OWNER to postgres;

CREATE TABLE IF NOT EXISTS public.stadyum
(
    stadyum_id integer NOT NULL,
    stadyum_ad character varying(40) COLLATE pg_catalog."default" NOT NULL,
    stadyum_kapasite integer NOT NULL,
    CONSTRAINT stadyum_pkey PRIMARY KEY (stadyum_id)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.stadyum
    OWNER to postgres;

CREATE TABLE IF NOT EXISTS public.takim
(
    takim_id integer NOT NULL,
    takim_ad character varying(40) COLLATE pg_catalog."default" NOT NULL,
    stadyum_id integer,
    lig_id integer,
    CONSTRAINT takim_pkey PRIMARY KEY (takim_id),
    CONSTRAINT takim_ligfk FOREIGN KEY (lig_id)
        REFERENCES public.lig (lig_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID,
    CONSTRAINT takim_stadyumidfk FOREIGN KEY (stadyum_id)
        REFERENCES public.stadyum (stadyum_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.takim
    OWNER to postgres;

-- Trigger: takimsayisiarttitrig

-- DROP TRIGGER IF EXISTS takimsayisiarttitrig ON public.takim;

CREATE OR REPLACE TRIGGER takimsayisiarttitrig
    AFTER INSERT
    ON public.takim
    FOR EACH ROW
    EXECUTE FUNCTION public.takimsayisiartti();

-- Trigger: takimsayisiazalttri

-- DROP TRIGGER IF EXISTS takimsayisiazalttri ON public.takim;

CREATE OR REPLACE TRIGGER takimsayisiazalttri
    AFTER DELETE
    ON public.takim
    FOR EACH ROW
    EXECUTE FUNCTION public.takimsayisiazalt();

CREATE TABLE IF NOT EXISTS public.toplamfutbolcusayisi
(
    sayi integer
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.toplamfutbolcusayisi
    OWNER to postgres;
CREATE TABLE IF NOT EXISTS public.toplamtakimsayisi
(
    sayi integer
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.toplamtakimsayisi
    OWNER to postgres;

CREATE TABLE IF NOT EXISTS public.ulke
(
    ulke_id integer NOT NULL,
    ulke_adi character varying(40) COLLATE pg_catalog."default",
    CONSTRAINT ulke_pkey PRIMARY KEY (ulke_id)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.ulke
    OWNER to postgres;

CREATE TABLE IF NOT EXISTS public.vucutolculeri
(
    olcu_id integer NOT NULL,
    boy double precision NOT NULL,
    kilo double precision NOT NULL,
    CONSTRAINT vucutolculeri_pkey PRIMARY KEY (olcu_id)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.vucutolculeri
    OWNER to postgres;

CREATE OR REPLACE FUNCTION public.kisibul(
	kisiid integer)
    RETURNS TABLE(kisid integer, ad character varying, soyad character varying) 
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE PARALLEL UNSAFE
    ROWS 1000

AS $BODY$
begin
	return query select kisi_id,kisi_ad,kisi_soyad from kisi where kisi_id=kisiid;
end;
$BODY$;

ALTER FUNCTION public.kisibul(integer)
    OWNER TO postgres;

CREATE OR REPLACE FUNCTION public.kitleboyendeks(
	kilo double precision,
	boy double precision)
    RETURNS double precision
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE PARALLEL UNSAFE
AS $BODY$
declare 
	sonuc double precision;
begin
	sonuc=kilo/(boy*boy);
	return kilo/(boy*boy);
end;
$BODY$;

ALTER FUNCTION public.kitleboyendeks(double precision, double precision)
    OWNER TO postgres;

CREATE OR REPLACE FUNCTION public.takimbul(
	takimid integer)
    RETURNS TABLE(takimidd integer, ad character varying) 
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE PARALLEL UNSAFE
    ROWS 1000

AS $BODY$
begin
	return query select takim_id,takim_ad from takim where takim_id=takimid;
end;
$BODY$;

ALTER FUNCTION public.takimbul(integer)
    OWNER TO postgres;

CREATE OR REPLACE PROCEDURE public.ulke_ekle(
	IN id integer,
	IN ad character varying)
LANGUAGE 'plpgsql'
AS $BODY$
begin
insert into ulke(ulke_id,ulke_adi) values(id,ad);
end;
$BODY$;
ALTER PROCEDURE public.ulke_ekle(integer, character varying)
    OWNER TO postgres;

CREATE OR REPLACE FUNCTION public.futbolcusayisiarttir()
    RETURNS trigger
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE NOT LEAKPROOF
AS $BODY$
begin
update toplamfutbolcusayisi set sayi=sayi+1;
return new;
end;
$BODY$;

ALTER FUNCTION public.futbolcusayisiarttir()
    OWNER TO postgres;

CREATE OR REPLACE TRIGGER futbolcusayisiarttirtrig
    AFTER INSERT
    ON public.futbolcu
    FOR EACH ROW
    EXECUTE FUNCTION public.futbolcusayisiarttir();
CREATE OR REPLACE FUNCTION public.futbolcusayisiazalt()
    RETURNS trigger
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE NOT LEAKPROOF
AS $BODY$
begin
update toplamfutbolcusayisi set sayi=sayi-1;
return new;
end;
$BODY$;

ALTER FUNCTION public.futbolcusayisiazalt()
    OWNER TO postgres;
CREATE OR REPLACE TRIGGER futbolcusayisiazalttrig
    AFTER DELETE
    ON public.futbolcu
    FOR EACH ROW
    EXECUTE FUNCTION public.futbolcusayisiazalt();

CREATE OR REPLACE FUNCTION public.silinenkayit()
    RETURNS trigger
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE NOT LEAKPROOF
AS $BODY$
  begin
    insert into silinenfutbolcular(skisi_id,skisi_takimid,skisi_mevkiid)
	values(OLD.kisi_id,OLD.takim_id,OLD.mevki_id);
  return new;
 end;
  
$BODY$;

ALTER FUNCTION public.silinenkayit()
    OWNER TO postgres;
CREATE OR REPLACE TRIGGER silinenkayittrig
    AFTER DELETE
    ON public.futbolcu
    FOR EACH ROW
    EXECUTE FUNCTION public.silinenkayit();

CREATE OR REPLACE FUNCTION public.takimsayisiartti()
    RETURNS trigger
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE NOT LEAKPROOF
AS $BODY$
begin
update toplamtakimsayisi set sayi=sayi+1;
return new;
end;
$BODY$;

ALTER FUNCTION public.takimsayisiartti()
    OWNER TO postgres;
CREATE OR REPLACE TRIGGER takimsayisiarttitrig
    AFTER INSERT
    ON public.takim
    FOR EACH ROW
    EXECUTE FUNCTION public.takimsayisiartti();
CREATE OR REPLACE FUNCTION public.takimsayisiazalt()
    RETURNS trigger
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE NOT LEAKPROOF
AS $BODY$
begin
update toplamtakimsayisi set sayi=sayi-1;
return new;
end;
$BODY$;

ALTER FUNCTION public.takimsayisiazalt()
    OWNER TO postgres;
CREATE OR REPLACE TRIGGER takimsayisiazalttri
    AFTER DELETE
    ON public.takim
    FOR EACH ROW
    EXECUTE FUNCTION public.takimsayisiazalt();